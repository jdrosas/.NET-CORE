using System.Collections;

namespace prj04_01.Models
{ 
    public class ShoppingCart : IEnumerable<Product?>
    { 
        public IEnumerable<Product?>? Products { get; set; }

        public IEnumerator<Product?> GetEnumerator() => Products?.GetEnumerator() ?? Enumerable.Empty<Product?>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
