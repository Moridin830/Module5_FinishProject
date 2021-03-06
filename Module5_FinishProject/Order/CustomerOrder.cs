using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_FinishProject
{
    public class CustomerOrder : Order
    {
        public int Id
        {
            get
            {
                return this.Id;
            }
            private set
            {
                Id = value;
            }
        }

        public string Description
        {
            get
            {
                return this.Description;
            }
            set
            {
                this.Description = value;
            }
        }

        public OrderItem[] ItemList
        {

        }

        public OrderItem this[int index]
        {
            get
            {
                return (OrderItem)this[index];
            }
            set
            {
                ItemList[int] = value;
            }
        }

        public CustomerOrder(string Description)
        {
            this.Id = Order.CurrentMaxId;
            this.Description = Description;
        }

        public CustomerOrder(string Description, OrderItem[] Items)
        {
            this.Id = Order.CurrentMaxId;
        }
    }
}
