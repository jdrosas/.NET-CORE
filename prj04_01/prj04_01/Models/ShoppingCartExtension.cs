using System.Collections;

namespace prj04_01.Models
{
    public static class ShoppingCartExtension
    {
        public static decimal TotalPrices(this IEnumerable<Product?> products)
        {
            decimal total = 0;

            foreach (Product? prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }

        public static IEnumerable<Product?> FilterByPrice(
            this IEnumerable<Product?> productEnum,
            decimal minimumPrice)
        { 
            return productEnum.Where(x => (x?.Price ?? 0) >= minimumPrice);

            //foreach (Product? prod in productEnum)
            //{
            //    if ((prod?.Price ?? 0) >= minimumPrice)
            //    {
            //        yield return prod;
            //    }
            //}
        }


        public static IEnumerable<Product?> FilterByName(
            this IEnumerable<Product?> productEnum,
            Func<Product?, bool> selector)
        {
            return productEnum.Where(x => selector(x));

            //return from x in productEnum
            //       where selector(x)
            //       select x;

        }
    }



    //public static IEnumerable<Product?> FilterByName(
    //        this IEnumerable<Product?> productEnum,
    //        Func<Product?, bool> selector)
    //{
    //    return productEnum.Where(x => selector(x));



    //    //return from x in productEnum
    //    //       where selector(x)
    //    //       select x;
    //}


    //public static decimal TotalPrices(this ShoppingCart cartParam)
    //{
    //    decimal total = 0;
    //    if (cartParam.Products != null) 
    //    {
    //        foreach (Product? prod in cartParam.Products)
    //        {
    //            total += prod?.Price ?? 0;
    //        }
    //    }
    //    return total;
    //}
    //public static IEnumerable<Product?> FilterByPrice(
    //                this IEnumerable<Product?> productEnum,
    //                decimal minimumPrice)
    //{
    //    return productEnum.Where(x => (x?.Price ?? 0) >= minimumPrice);
}

