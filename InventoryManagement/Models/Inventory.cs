using System.ComponentModel;
using System.Linq;

namespace InventoryManagement.Models
{
    public static class Inventory
    {
        #region private feilds

        private static int maxProductId = 0;
        private static int maxPartId = 0;

        #endregion

        #region public properties
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();
        #endregion

        #region public Product methods
        public static void AddProduct(Product product)
        {
            product.ProductID = GetNewProductId();
            Products.Add(product);
        }

        public static Product LookupProduct(int productId)
        {
            return Products.FirstOrDefault(product => product.ProductID == productId);
        }

        public static bool RemoveProduct(int productId)
        {
            var product = LookupProduct(productId);
            if (product == null)
            {
                return false;
            }
            return Products.Remove(product);
        }

        public static void UpdateProduct(int id, Product newProduct)
        {
            var index = Products.ToList().FindIndex(product => product.ProductID == id);
            if (index > -1) // if index is -1 then we couldn't find the product to update
            {
                newProduct.ProductID = id; // ensures id's stay static
                Products.RemoveAt(index);
                Products.Insert(index, newProduct);
            }
        }
        #endregion

        #region public Part methods

        public static void AddPart(Part part)
        {
            part.PartID = GetNewPartId();
            AllParts.Add(part);
        }

        public static Part LookupPart(int partId)
        {
            return AllParts.FirstOrDefault(part => part.PartID == partId);
        }

        public static bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public static void UpdatePart(int id, Part newPart)
        {
            var index = AllParts.ToList().FindIndex(part => part.PartID == id);
            if (index > -1) // if index is -1 then we couldn't find the part to update
            {
                newPart.PartID = id; // ensures id's stay static
                AllParts.RemoveAt(index);
                AllParts.Insert(index, newPart);
            }
        }

        #endregion

        #region init test data
        public static void InitParts()
        {
            AddPart(new Inhouse()
            {
                Name = "Wheel",
                InStock = 15,
                Price = 12.11m,
                Min = 5,
                Max = 25,
                MachineID = 15525
            });

            AddPart(new Outsourced()
            {
                Name = "Pedal",
                InStock = 11,
                Price = 8.22m,
                Min = 5,
                Max = 25,
                CompanyName = "The Pedal Co."
            });

            AddPart(new Inhouse()
            {
                Name = "Chain",
                InStock = 12,
                Price = 8.33m,
                Min = 5,
                Max = 25,
                MachineID = 12525
            });

            AddPart(new Outsourced()
            {
                Name = "Seat",
                InStock = 8,
                Price = 4.55m,
                Min = 2,
                Max = 15,
                CompanyName = "Sit Down inc."
            });
        }

        public static void InitProducts()
        {
            AddProduct(new Product()
            {
                Name = "Red Bicycle",
                InStock = 15,
                Price = 11.44m,
                Min = 1,
                Max = 25
            });

            AddProduct(new Product()
            {
                Name = "Yellow Bicycle",
                InStock = 19,
                Price = 9.66m,
                Min = 1,
                Max = 20
            });

            AddProduct(new Product()
            {
                Name = "Blue Bicycle",
                InStock = 5,
                Price = 12.77m,
                Min = 1,
                Max = 25
            });
        }

        #endregion

        #region private methods

        private static int GetNewProductId()
        {
            maxProductId++;
            return maxProductId;
        }

        private static int GetNewPartId()
        {
            maxPartId++;
            return maxPartId;
        }

        #endregion
    }
}