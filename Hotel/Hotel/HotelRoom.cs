using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class HotelRoom
    {
        private int beds_;
        private int bathrooms_;

        public HotelRoom(int beds, int bathrooms) {
            beds_ = beds;
            bathrooms_ = bathrooms;
        }

        public int GetPrice()
        {
            return 50 * beds_ + 100 * bathrooms_;
        }

        

    }

    class HotelApartment : HotelRoom
    {
        public HotelApartment(int beds, int bathrooms) : base(beds, bathrooms) { }


        public int GetPrice()
        {
            return base.GetPrice() + 100;
        }

    }
}
