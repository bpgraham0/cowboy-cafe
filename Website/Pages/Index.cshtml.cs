using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;



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
            /*
            itemList = Menu.Search(itemList, SearchTerms);
            itemList = Menu.FilterByCategory(itemList, Categories);
            
            itemList = Menu.FilterByCalories(itemList, CaloriesMin, CaloriesMax);
            itemList = Menu.FilterByPrice(itemList, PriceMin, PriceMax);
            */

            if (SearchTerms != null)
            {
                itemList = from item in itemList
                           where item.ToString() != null && item.Name().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                           select item;
            }
            if (Categories != null && Categories.Length != 0)
            {
                itemList = from item in itemList
                           where Categories.Contains(item.Category)
                           select item;
                
            }

            //couldn't figure how to adapt the where clause to allow for different sizes so only works for defaults
            if (CaloriesMax != null || CaloriesMin != null)
            {
                if (CaloriesMin == null)
                {

                    itemList = from item in itemList
                             where item.Calories <= CaloriesMax
                             select item;
                }

                else if (CaloriesMax == null)
                {

                    itemList = from item in itemList
                             where item.Calories >= CaloriesMin
                             select item;
                }

                else
                {
                    itemList = from item in itemList
                             where item.Calories >= CaloriesMin && item.Calories <= CaloriesMax
                             select item;
                }
            }

            //couldn't figure how to adapt the where clause to allow for different sizes so only works for defaults
            if (PriceMax != null || PriceMin != null)
            {
                if (PriceMin == null)
                {
                    itemList = from item in itemList
                               where item.Price <= PriceMax
                               select item;
                }

                else if (PriceMax == null)
                {

                    itemList = from item in itemList
                               where item.Price >= PriceMin
                               select item;
                }

                else
                {
                    itemList = from item in itemList
                               where item.Price >= PriceMin && item.Price <= PriceMax
                               select item;
                }
            }


        }
    }
}
