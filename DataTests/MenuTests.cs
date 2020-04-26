using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.Linq;
using Xunit;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace CowboyCafe.DataTests
{
    public class MenuTests
    {


        //entrees should contain angry chicken, cowpoke chili, dakota double, pecos pulled pork, 
        //rustlers ribs, texas triple, and trail burger
        [Fact]
        public void MenuEntreesShouldContainAllEntrees()
        {
            Assert.Collection(
                Menu.Entrees(),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (dd) => { Assert.IsType<DakotaDoubleBurger>(dd); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (tt) => { Assert.IsType<TexasTripleBurger>(tt); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }
        /// <summary>
        /// entrees should return 7 items
        /// </summary>
        [Fact]
        public void MenuEntreesShouldContainSevenItems()
        {
            Assert.Equal(7, Menu.Entrees().Count());
        }

        //sides should contain  baked beans, chili cheese fries, corn dodgers, and pan de campo
        [Fact]
        public void MenuSidesShouldContainAllSides()
        {
            Assert.Collection(
                Menu.Sides(),
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        /// <summary>
        /// sides should return 4 items
        /// </summary>
        [Fact]
        public void MenuSidesShouldContainFourItems()
        {
            Assert.Equal(4, Menu.Sides().Count());
        }


        //drinks should contain Cowboy Coffee, Jerked Soda, Texas Tea, Water
        [Fact]
        public void MenuDrinksShouldContainAllDrinks()
        {
            Assert.Collection(
                Menu.Drinks(),
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        /// <summary>
        /// drinks should return 4 items
        /// </summary>
        [Fact]
        public void MenuDrinksShouldContainFourItems()
        {
            Assert.Equal(4, Menu.Drinks().Count());
        }

        /// <summary>
        /// complete menu should return all items
        /// </summary>
        [Fact]
        public void CompleteMenuShouldContainAllItems()
        {
            Assert.Collection(
                Menu.CompleteMenu(),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (dd) => { Assert.IsType<DakotaDoubleBurger>(dd); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (tt) => { Assert.IsType<TexasTripleBurger>(tt); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        /// <summary>
        /// Complete Menu should return 15 items
        /// </summary>
        [Fact]
        public void CompleteMenuShouldContainFifteenItems()
        {
            Assert.Equal(15, Menu.CompleteMenu().Count());
        }

        //Search method should filter terms
        [Theory]
        [InlineData("")]
        [InlineData("cow")]
        [InlineData("burger")]
        [InlineData(null)]
        public void SearchShouldFilterTerms(string terms)
        {
            IEnumerable<IOrderItem> itemList = Menu.CompleteMenu();
            itemList = Menu.Search(itemList, terms);
            if (terms == null||terms.Equals(""))
            {
                Assert.Collection(
                itemList,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (dd) => { Assert.IsType<DakotaDoubleBurger>(dd); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (tt) => { Assert.IsType<TexasTripleBurger>(tt); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
            }
            else if (terms.Equals("cow"))
            {

                Assert.Collection(
                    itemList,
                    (chili) => { Assert.IsType<CowpokeChili>(chili); },
                    (coffee) => { Assert.IsType<CowboyCoffee>(coffee); }
                    );


            }
            else if (terms.Equals("burger"))
            {
                Assert.Collection(
                itemList,
                (dd) => { Assert.IsType<DakotaDoubleBurger>(dd); },
                (tt) => { Assert.IsType<TexasTripleBurger>(tt); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
            }

        }
        /// <summary>
        /// filter by category should filter by categories
        /// </summary>
        [Theory]
        [InlineData("Entree","Side","Drink")]
        [InlineData("Entree")]
        [InlineData("Side")]
        [InlineData("Drink")]
        [InlineData(null)]

        public void FilterByCategoryShouldFilterCategories(params string[] categories)
        {
            IEnumerable<IOrderItem> itemList = Menu.CompleteMenu();
            itemList = Menu.FilterByCategory(itemList, categories);

            if(categories == null||(categories.Contains("Entree")&& categories.Contains("Side")&& categories.Contains("Drink")))
            {
                Assert.Collection(
                itemList,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (dd) => { Assert.IsType<DakotaDoubleBurger>(dd); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (tt) => { Assert.IsType<TexasTripleBurger>(tt); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
            }
            else if (categories.Contains("Entree"))
            {
                Assert.Collection(
                itemList,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (dd) => { Assert.IsType<DakotaDoubleBurger>(dd); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (tt) => { Assert.IsType<TexasTripleBurger>(tt); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
            }
            else if (categories.Contains("Side"))
            {
                Assert.Collection(
                itemList,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
            }
            else if (categories.Contains("Drink"))
            {
                Assert.Collection(
                itemList,
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
            }
        }

        /// <summary>
        /// filter by calories chould filter by calories
        /// </summary>
        /// <param name="min">min calories</param>
        /// <param name="max">max calories</param>
        [Theory]
        [InlineData(0,1000)]
        [InlineData(null, 1000)]
        [InlineData(0, null)]
        [InlineData(null, null)]
        [InlineData(200,300)]
        [InlineData(600, 700)]

        public void FilterByCaloriesShouldFilterByCalories(int? min, int? max) 
        {
            IEnumerable<IOrderItem> itemList = Menu.CompleteMenu();
            itemList = Menu.FilterByCalories(itemList, min ,max);

            if (min == 200)//tests for item that has over 200 calories for large 
            {
                Assert.Collection(
                   itemList,
                   (tb) => { Assert.IsType<TrailBurger>(tb); },
                   (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                   );
            }
            else if (min == 600) //checks forr item with 600 calories for medium
            {
                Assert.Collection(
                    itemList,
                    (tt) => { Assert.IsType<TexasTripleBurger>(tt); },
                    (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                    (cd) => { Assert.IsType<CornDodgers>(cd); }
                    );
            }
            else
            {
                Assert.Collection(
                    itemList,
                    (ac) => { Assert.IsType<AngryChicken>(ac); },
                    (cc) => { Assert.IsType<CowpokeChili>(cc); },
                    (dd) => { Assert.IsType<DakotaDoubleBurger>(dd); },
                    (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                    (rr) => { Assert.IsType<RustlersRibs>(rr); },
                    (tt) => { Assert.IsType<TexasTripleBurger>(tt); },
                    (tb) => { Assert.IsType<TrailBurger>(tb); },
                    (bb) => { Assert.IsType<BakedBeans>(bb); },
                    (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                    (cd) => { Assert.IsType<CornDodgers>(cd); },
                    (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                    (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                    (js) => { Assert.IsType<JerkedSoda>(js); },
                    (tt) => { Assert.IsType<TexasTea>(tt); },
                    (w) => { Assert.IsType<Water>(w); }
                    );
            }

        }

        /// <summary>
        /// filter by price chould filter by price
        /// </summary>
        /// <param name="min">min price</param>
        /// <param name="max">max price</param>
        [Theory]
        [InlineData(0, 10)]
        [InlineData(null, 10)]
        [InlineData(0, null)]
        [InlineData(null, null)]
        [InlineData(2.00, 3.00)]

        public void FilterByPriceShouldFilterByPrice(double? min, double? max)
        {
            IEnumerable<IOrderItem> itemList = Menu.CompleteMenu();
            itemList = Menu.FilterByPrice(itemList, min, max);

            if (min == 2.00)//tests for item that has over $2.00 for medium and large 
            {
                Assert.Collection(
                    itemList,
                    (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                    (js) => { Assert.IsType<JerkedSoda>(js); },
                    (tt) => { Assert.IsType<TexasTea>(tt); }
                    );
            }
            else
            {
                Assert.Collection(
                    itemList,
                    (ac) => { Assert.IsType<AngryChicken>(ac); },
                    (cc) => { Assert.IsType<CowpokeChili>(cc); },
                    (dd) => { Assert.IsType<DakotaDoubleBurger>(dd); },
                    (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                    (rr) => { Assert.IsType<RustlersRibs>(rr); },
                    (tt) => { Assert.IsType<TexasTripleBurger>(tt); },
                    (tb) => { Assert.IsType<TrailBurger>(tb); },
                    (bb) => { Assert.IsType<BakedBeans>(bb); },
                    (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                    (cd) => { Assert.IsType<CornDodgers>(cd); },
                    (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                    (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                    (js) => { Assert.IsType<JerkedSoda>(js); },
                    (tt) => { Assert.IsType<TexasTea>(tt); },
                    (w) => { Assert.IsType<Water>(w); }
                    );
            }

        }
    }
}
