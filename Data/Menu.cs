using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// iterates through each of the entrees
        /// </summary>
        /// <returns>each entree</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            yield return new AngryChicken();
            yield return new CowpokeChili();
            yield return new DakotaDoubleBurger();
            yield return new PecosPulledPork();
            yield return new RustlersRibs();
            yield return new TexasTripleBurger();
            yield return new TrailBurger();

        }

        /// <summary>
        /// iterates thorugh each side
        /// </summary>
        /// <returns>each side</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            yield return new BakedBeans();
            yield return new ChiliCheeseFries();
            yield return new CornDodgers();
            yield return new PanDeCampo();
        }

        /// <summary>
        /// iterates through each drink
        /// </summary>
        /// <returns>each drink</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            yield return new CowboyCoffee();
            yield return new JerkedSoda();
            yield return new TexasTea();
            yield return new Water();
        }

        /// <summary>
        /// iterates through the menu
        /// </summary>
        /// <returns>each item</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            yield return new AngryChicken();
            yield return new CowpokeChili();
            yield return new DakotaDoubleBurger();
            yield return new PecosPulledPork();
            yield return new RustlersRibs();
            yield return new TexasTripleBurger();
            yield return new TrailBurger();

            yield return new BakedBeans();
            yield return new ChiliCheeseFries();
            yield return new CornDodgers();
            yield return new PanDeCampo();

            yield return new CowboyCoffee();
            yield return new JerkedSoda();
            yield return new TexasTea();
            yield return new Water();
        }

        /// <summary>
        /// Searches the database for matching items
        /// </summary>
        /// <param name="itemList">The collection of items to filter</param>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of items</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> itemList , string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null)
            {
                return itemList;
            }
            foreach (IOrderItem item in itemList)
            {
                if (item.ToString() != null && item.Name().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// gets possible categories
        /// </summary>
        public static string[] Categories
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        /// <summary>
        /// Filters the provided collection of items
        /// </summary>
        /// <param name="itemList">The collection of items to filter</param>
        /// <param name="categories">The categories to include</param>
        /// <returns>A collection containing only item that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory (IEnumerable<IOrderItem> itemList, IEnumerable<string> categories)
        {
            // If no filter is specified, just return the provided collection
            if (categories == null || categories.Count() == 0) return itemList;

            List<IOrderItem> results = new List<IOrderItem>();
            
            foreach(var category in categories)
            {
                if (category.Equals("Entree"))
                {
                    foreach(IOrderItem item in Entrees())
                    {
                        results.Add(item);
                    }
                }
                if (category.Equals("Side"))
                {
                    foreach (IOrderItem item in Sides())
                    {
                        results.Add(item);
                    }
                }
                if (category.Equals("Drink"))
                {
                    foreach (IOrderItem item in Drinks())
                    {
                        results.Add(item);
                    }
                }

            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of items
        /// </summary>
        /// <param name="itemList">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>A collection containing only item that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> itemList, int? min, int? max)
        {
            if (min == null && max == null) return itemList;

            List<IOrderItem> results = new List<IOrderItem>();

            //only max specified
            if (min == null)
            {
                foreach (IOrderItem item in itemList)
                {
                    if (item is Drink drink)
                    {
                        drink.Size = Size.Small;
                        if (drink.Calories <= max) 
                        { 
                            results.Add(item); 
                        }
                        else
                        {
                            drink.Size = Size.Medium;
                            if (drink.Calories <= max)
                            {

                                results.Add(item);
                            }
                            else
                            {
                                drink.Size = Size.Large;
                                if(drink.Calories <= max)
                                {
                                    results.Add(item);
                                }
                            }
                        }
                    }
                    else if (item is Side side)
                    {
                        side.Size = Size.Small;
                        if (side.Calories <= max)
                        {
                            results.Add(item);
                        }
                        else
                        {
                            side.Size = Size.Medium;
                            if (side.Calories <= max)
                            {
                                results.Add(item);
                            }
                            else
                            {
                                side.Size = Size.Large;
                                if (side.Calories <= max)
                                {
                                    results.Add(item);
                                }
                            }
                        }
                    }
                    else if (item.Calories <= max) results.Add(item);
                }
                return results;
            }


            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in itemList)
                {
                    if (item is Drink drink)
                    {
                        drink.Size = Size.Large;
                        if (drink.Calories >= min)
                        {
                            results.Add(item);
                        }
                        else
                        {
                            drink.Size = Size.Medium;
                            if (drink.Calories >= min)
                            {
                                results.Add(item);
                            }
                            else
                            {
                                drink.Size = Size.Small;
                                if (drink.Calories >= min)
                                {
                                    results.Add(item);
                                }
                            }
                        }
                    }
                    else if (item is Side side)
                    {
                        side.Size = Size.Large;
                        if (side.Calories >= min)
                        {
                            results.Add(item);
                        }
                        else
                        {
                            side.Size = Size.Medium;
                            if (side.Calories >= min)
                            {
                                results.Add(item);
                            }
                            else
                            {
                                side.Size = Size.Small;
                                if (side.Calories >= min)
                                {
                                    results.Add(item);
                                }
                            }
                        }
                    }
                    else if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in itemList)
            {
                if (item is Drink drink)
                {
                    drink.Size = Size.Small;
                    if (drink.Calories >= min && drink.Calories <= max)
                    {
                        results.Add(item);
                    }
                    else
                    {
                        drink.Size = Size.Medium;
                        if (drink.Calories >= min && drink.Calories <= max)
                        {
                            results.Add(item);
                        }
                        else
                        {
                            drink.Size = Size.Large;
                            if (drink.Calories >= min && drink.Calories <= max)
                            {
                                results.Add(item);
                            }
                        }
                    }
                }
                else if (item is Side side)
                {
                    side.Size = Size.Small;
                    if (side.Calories >= min && side.Calories <= max)
                    {
                        results.Add(item);
                    }
                    else
                    {
                        side.Size = Size.Medium;
                        if (side.Calories >= min && side.Calories <= max)
                        {
                            results.Add(item);
                        }
                        else
                        {
                            side.Size = Size.Large;
                            if (side.Calories >= min && side.Calories <= max)
                            {
                                results.Add(item);
                            }
                        }
                    }
                }
                else if (item.Calories >= min && item.Calories <= max) results.Add(item);
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of items
        /// </summary>
        /// <param name="itemList">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>A collection containing only item that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> itemList, double? min, double? max)
        {
            if (min == null && max == null) return itemList;

            List<IOrderItem> results = new List<IOrderItem>();

            //only max specified
            if (min == null)
            {
                foreach (IOrderItem item in itemList)
                {
                    if (item is Drink drink)
                    {
                        drink.Size = Size.Small;
                        if (drink.Price <= max)
                        {
                            results.Add(item);
                        }
                        else
                        {
                            drink.Size = Size.Medium;
                            if (drink.Price <= max)
                            {
                                results.Add(item);
                            }
                            else
                            {
                                drink.Size = Size.Large;
                                if (drink.Price <= max)
                                {
                                    results.Add(item);
                                }
                            }
                        }
                    }
                    else if (item is Side side)
                    {
                        side.Size = Size.Small;
                        if (side.Price <= max)
                        {
                            results.Add(item);
                        }
                        else
                        {
                            side.Size = Size.Medium;
                            if (side.Price <= max)
                            {
                                results.Add(item);
                            }
                            else
                            {
                                side.Size = Size.Large;
                                if (side.Price <= max)
                                {
                                    results.Add(item);
                                }
                            }
                        }
                    }
                    else if (item.Price <= max) results.Add(item);
                }
                return results;
            }


            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in itemList)
                {
                    if (item is Drink drink)
                    {
                        drink.Size = Size.Large;
                        if (drink.Price >= min)
                        {
                            results.Add(item);
                        }
                        else
                        {
                            drink.Size = Size.Medium;
                            if (drink.Price >= min)
                            {
                                results.Add(item);
                            }
                            else
                            {
                                drink.Size = Size.Small;
                                if (drink.Price >= min)
                                {
                                    results.Add(item);
                                }
                            }
                        }
                    }
                    else if (item is Side side)
                    {
                        side.Size = Size.Large;
                        if (side.Price >= min)
                        {
                            results.Add(item);
                        }
                        else
                        {
                            side.Size = Size.Medium;
                            if (side.Price >= min)
                            {
                                results.Add(item);
                            }
                            else
                            {
                                side.Size = Size.Small;
                                if (side.Price >= min)
                                {
                                    results.Add(item);
                                }
                            }
                        }
                    }
                    else if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in itemList)
            {
                if (item is Drink drink)
                {
                    drink.Size = Size.Small;
                    if (drink.Price >= min && drink.Price <= max)
                    {
                        results.Add(item);
                    }
                    else
                    {
                        drink.Size = Size.Medium;
                        if (drink.Price >= min && drink.Price <= max)
                        {
                            results.Add(item);
                        }
                        else
                        {
                            drink.Size = Size.Large;
                            if (drink.Price >= min && drink.Price <= max)
                            {
                                results.Add(item);
                            }
                        }
                    }
                }
                else if (item is Side side)
                {
                    side.Size = Size.Small;
                    if (side.Price >= min && side.Price <= max)
                    {
                        results.Add(item);
                    }
                    else
                    {
                        side.Size = Size.Medium;
                        if (side.Price >= min && side.Price <= max)
                        {
                            results.Add(item);
                        }
                        else
                        {
                            side.Size = Size.Large;
                            if (side.Price >= min && side.Price <= max)
                            {
                                results.Add(item);
                            }
                        }
                    }
                }
                else if (item.Price >= min && item.Price <= max) results.Add(item);
            }
            return results;
        }
    }
}
