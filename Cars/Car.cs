namespace Cars
{
    internal class CarClass
    {
        public string Mark;
        public string Model;
        public string Color;
        public string Number;


        public CarClass(string mark = "No mark", string model = "model", string color = "No color", string number = "No number")
        {
            this.Mark = mark;
            this.Model = model;
            this.Color = color;
            this.Number = number;
        }
    }
}
