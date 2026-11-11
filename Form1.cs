using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Lab5
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        List<Brand> brands = new List<Brand>();

        public Form1()
        {

            InitializeComponent();

            Car car1 = new Car("V70", 3000, "Volvo");
            Car car2 = new Car("M5", 55000, "BMW");
            Car car3 = new Car("Yuan Up", 18000, "BYD");
            Car car4 = new Car("RS7", 80000, "Audi");
            Car car5 = new Car("Vesta", 10000, "Lada");
            Car car6 = new Car("X6", 50000, "BMW");
            Car car7 = new Car("XC90", 90000, "Volvo");
            Car car8 = new Car("Q8", 100000, "Audi");
            Car car9 = new Car("QLS4500", 45000, "Mercedes");
            Car car10 = new Car("Polo", 5000, "Volkswagen");

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);
            cars.Add(car6);
            cars.Add(car7);
            cars.Add(car8);
            cars.Add(car9);
            cars.Add(car10);
            dgvCars.DataSource = cars;

            Brand brand1 = new Brand("Volvo", "Sweden", 1927);
            Brand brand2 = new Brand("Lada", "Russia", 1966);
            Brand brand3 = new Brand("Audi", "Germany", 1909);
            Brand brand4 = new Brand("BYD", "China", 1995);
            Brand brand5 = new Brand("Mercedes", "Germany", 1926);
            Brand brand6 = new Brand("Volkswagen", "Germany", 1937);
            Brand brand7 = new Brand("BMW", "Germany", 1916);

            brands.Add(brand1);
            brands.Add(brand2);
            brands.Add(brand3);
            brands.Add(brand4);
            brands.Add(brand5);
            brands.Add(brand6);
            brands.Add(brand7);
            dgvBrands.DataSource = brands;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var result = cars.Where(car => car.Price > 50000).ToList();
            dgvCars.DataSource = null;
            dgvCars.DataSource = result;

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvCars.DataSource = null;
            dgvCars.DataSource = cars;

        }
    }
}
