/* Author: Ben Graham
 * Class: ExtensionMethods.cs
 * Purpose: obtains ancestor of type passed in
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale.ExtensionMethods
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// gets the order control when within a child of ordercontrol
        /// </summary>
        /// <typeparam name="T">dependency object</typeparam>
        /// <param name="element">frameworkelement</param>
        /// <returns></returns>
        public static T FindAncestor<T>(this DependencyObject element) where T: DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);
            if(parent == null)
            {
                return null;
            }
            if (parent is T) return parent as T;

            return parent.FindAncestor<T>();
        }
    }
}
