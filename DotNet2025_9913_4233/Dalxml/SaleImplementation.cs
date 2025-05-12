using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal class SaleImplementation : Isale
    {
        private static string filePath = @"..\xml\sales.xml";
        private XElement LoadXml()
        {
            if (!File.Exists(filePath))
            {
                XElement root = new XElement("Sales");
                root.Save(filePath);
            }
            return XElement.Load(filePath);
        }

        private void SaveXml(XElement root)
        {
            root.Save(filePath);
        }
        public int Create(Sale item)
        {
            XElement root = LoadXml();
            item = item with { id = Config.NextSaleID };
            XElement saleElement = new XElement("Sale",
                new XElement("Id", item.id),
                new XElement("ProductId", item._productId),
                new XElement("QuantityForSale", item._quantityForSale),
                new XElement("SalePrice", item._salePrice),
                new XElement("IsForClubMembersOnly", item._isForClubMembersOnly),
                new XElement("DateStartSale", item._dateStartSale),
                new XElement("DateEndSale", item._dateEndSale)
            );

            root.Add(saleElement);
            SaveXml(root);
            return item.id;
        }

        public void Delete(int id)
        {
            XElement root = LoadXml();
            XElement saleElement = root.Elements("Sale").FirstOrDefault(e => (int)e.Element("Id") == id);
            if (saleElement == null)
                throw new DalNotFoundId("Sale not found");
            saleElement.Remove();
            SaveXml(root);
        }

        public Sale? Read(int id)
        {
            XElement root = LoadXml();
            XElement? saleElement = root.Elements("Sale")
                                       .FirstOrDefault(e => (int)e.Element("Id") == id);
            if (saleElement == null)
                throw new DalNotFoundId("Sale not found");

            return new Sale
            {

                id = (int)saleElement.Element("Id"),
                _productId = (int)saleElement.Element("ProductId"),
                _quantityForSale = (int)saleElement.Element("QuantityForSale"),
                _salePrice = (int)saleElement.Element("SalePrice"),
                _isForClubMembersOnly = (bool)saleElement.Element("IsForClubMembersOnly"),
                _dateStartSale = DateTime.Parse(saleElement.Element("DateStartSale")!.Value),
                _dateEndSale = DateTime.Parse(saleElement.Element("DateEndSale")!.Value)
            };
        }

        public Sale? Read(Func<Sale, bool>? filter)
        {
            XElement root = LoadXml();

            IEnumerable<Sale> sales = root.Elements("Sale")
                            .Select(e => new Sale
                            {
                                id = (int)e.Element("Id"),
                                _productId = (int)e.Element("ProductId"),
                                _quantityForSale = (int)e.Element("QuantityForSale"),
                                _salePrice = (int)e.Element("SalePrice"),
                                _isForClubMembersOnly = (bool)e.Element("IsForClubMembersOnly"),
                                _dateStartSale = DateTime.Parse(e.Element("DateStartSale")!.Value),
                                _dateEndSale = DateTime.Parse(e.Element("DateEndSale")!.Value)
                            });

            Sale sale = filter == null ? sales.FirstOrDefault() : sales.FirstOrDefault(filter);

            if (sale == null)
                throw new DalNotFoundId("Sale not found");

            return sale;
        }



        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            XElement root = LoadXml();
            IEnumerable<Sale> sales = root.Elements("Sale")
                        .Select(e => new Sale
                        {
                            id = (int)e.Element("Id"),
                            _productId = (int)e.Element("ProductId"),
                            _quantityForSale = (int)e.Element("QuantityForSale"),
                            _salePrice = (int)e.Element("SalePrice"),
                            _isForClubMembersOnly = (bool)e.Element("IsForClubMembersOnly"),
                            _dateStartSale = DateTime.Parse(e.Element("DateStartSale")!.Value),
                            _dateEndSale = DateTime.Parse(e.Element("DateEndSale")!.Value)
                        });

            return (filter == null ? sales : sales.Where(filter)).Cast<Sale?>().ToList();
        }

        public void Update(Sale item)
        {
            XElement root = LoadXml();
            XElement? saleElement = root.Elements("Sale")
      .FirstOrDefault(e => (int?)e.Element("Id") == item.id);

            if (saleElement == null)
                throw new DalNotFoundId("Sale not found");

            saleElement.Element("ProductId")!.Value = item._productId.ToString();
            saleElement.Element("QuantityForSale")!.Value = item._quantityForSale.ToString();
            saleElement.Element("SalePrice")!.Value = item._salePrice.ToString();
            saleElement.Element("IsForClubMembersOnly")!.Value = item._isForClubMembersOnly.ToString();
            saleElement.Element("DateStartSale")!.Value = item._dateStartSale.ToString("o");
            saleElement.Element("DateEndSale")!.Value = item._dateEndSale.ToString("o");

            SaveXml(root);

        }


    }
}
