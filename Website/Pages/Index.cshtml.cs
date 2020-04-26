using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;


namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// the items to display on index page
        /// </summary>
        public IEnumerable<IOrderItem> itemList { get; protected set; }

        /// <summary>
        /// The current search terms
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// filtered categories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; } = new string[0];

        /// <summary>
        /// the minimum calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// the maximum calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// the minimum price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// the maximum calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        /// <summary>
        /// gets the results for diisplay on page
        /// </summary>
        public void OnGet()
        {
            itemList = Menu.CompleteMenu();
            itemList = Menu.Search(itemList, SearchTerms);
            itemList = Menu.FilterByCategory(itemList, Categories);
            itemList = Menu.FilterByCalories(itemList, CaloriesMin, CaloriesMax);
            itemList = Menu.FilterByPrice(itemList, PriceMin, PriceMax);
            

        }
    }
}
