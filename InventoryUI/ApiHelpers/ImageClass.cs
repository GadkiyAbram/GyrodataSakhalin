using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryUI.ApiHelpers
{
    public class ImageClass
    {
        private static byte[] GetItemImage(string imgLocation)
        {
            byte[] itemImage = null;
            if (imgLocation != null)
            {
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                itemImage = brs.ReadBytes((int)stream.Length);
            }
            return itemImage;
        }

        public static string prepareImageToString(string imgLocation)
        {
            string readyImage = null;
            byte[] itemImage = GetItemImage(imgLocation);
            if (itemImage != null) { readyImage = Convert.ToBase64String(itemImage); }

            return readyImage;
        }
    }
}
