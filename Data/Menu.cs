using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
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


        public static IEnumerable<IOrderItem> Sides()
        {
            yield return new BakedBeans();
            yield return new ChiliCheeseFries();
            yield return new CornDodgers();
            yield return new PanDeCampo();
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            yield return new CowboyCoffee();
            yield return new JerkedSoda();
            yield return new TexasTea();
            yield return new Water();
        }

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

    }
}
