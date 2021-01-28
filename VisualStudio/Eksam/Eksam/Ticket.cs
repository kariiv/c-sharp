namespace Eksam
{
    class Ticket
    {
        private string _passengerName, _flightDate, _destination, _location;
        private int _type, _seat;
        private double _price;
        private bool _refundable;

        public string Name
        {
            get { return this._passengerName; }
            set { this._passengerName = value; }
        }
        public string FlightDate
        {
            get { return this._flightDate; }
            set { this._flightDate = value; }
        }
        public double Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        public int Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        public int Seat
        {
            get { return this._seat; }
            set { this._seat = value; }
        }
        public bool Refundable
        {
            get { return this._refundable; }
            set { this._refundable = value; }
        }

        public string PrintTicketInfo()
        {
            return "Name: " + _passengerName +
                "\t\nFlight date: " + _flightDate +
                "\t\nPrice: " + _price + PrintRefundTag() +
                "\t\nFrom: " + _location + " to " + _destination +
                "\t\nTicket type: " + TicketType() + 
                "\t\nSeat number: " + _seat +
                "\t\nHave a nice Flight!";
        }
        private string TicketType()
        {
            if (_type == 1)
                return "business";
            else if (_type == 2)
                return "economy";
            else
                return "Unknown";
        }
        private string PrintRefundTag()
        {
            if (_refundable)
                return " (ReF.)";
            return "\t";
        }
    }
}
