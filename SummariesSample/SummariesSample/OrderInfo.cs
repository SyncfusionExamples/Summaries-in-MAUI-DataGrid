using System.ComponentModel;

namespace SummariesSample
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int orderID;
        private string? id;
        private int employeeID;
        private string? customerID;
        private string? firstname;
        private string? lastname;
        private string? shipCity;
        private string? shipCountry;
        private double freight;
        private DateTime shippingDate;
        private double price;

        public OrderInfo()
        {
        }

        public int OrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                orderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        public string? ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                RaisePropertyChanged("ID");
            }
        }

        public int EmployeeID
        {
            get
            {
                return employeeID;
            }

            set
            {
                employeeID = value;
                RaisePropertyChanged("EmployeeID");
            }
        }

        public string? CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        public string? FirstName
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
                RaisePropertyChanged("FirstName");
            }
        }

        public string? LastName
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
                RaisePropertyChanged("LastName");
            }
        }

        public string? ShipCity
        {
            get
            {
                return shipCity;
            }

            set
            {
                shipCity = value;
                RaisePropertyChanged("ShipCity");
            }
        }

        public string? ShipCountry
        {
            get
            {
                return this.shipCountry;
            }

            set
            {
                shipCountry = value;
                RaisePropertyChanged("ShipCountry");
            }
        }

        public double Freight
        {
            get
            {
                return freight;
            }

            set
            {
                freight = value;
                RaisePropertyChanged("Freight");
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
                RaisePropertyChanged("Price");
            }
        }

        public DateTime ShippingDate
        {
            get
            {
                return shippingDate;
            }

            set
            {
                shippingDate = value;
                RaisePropertyChanged("ShippingDate");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}