using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;

namespace App1.Services
{
    interface CartService
    {
        List<CartItem> GetCart();
        bool AddToCart(CartItem item);
        bool RemoveItem(CartItem item);
        bool UpdateCart(CartItem item, int qty);
        bool ClearCart();
    }
}
