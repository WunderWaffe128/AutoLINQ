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
            dgvCars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvBrands.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            dgvCars.RowHeadersVisible = false;
            dgvBrands.RowHeadersVisible = false;
            cmbOperation.SelectedIndex = 0;

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
            Brand brand8 = new Brand("BelGee", "Belarus",2011);

            brands.Add(brand1);
            brands.Add(brand2);
            brands.Add(brand3);
            brands.Add(brand4);
            brands.Add(brand5);
            brands.Add(brand6);
            brands.Add(brand7);
            brands.Add(brand8);
            dgvBrands.DataSource = brands;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var result = from car in cars
                         where car.Price > 50000
                         select car;
            dgvCars.DataSource = null;
            dgvCars.DataSource = result.ToList();

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvCars.DataSource = null;
            dgvCars.DataSource = cars;

        }

        private void btnFilterTwo_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMaxPrice.Text, out decimal inputPrice))
            {
                var result = from car in cars
                             where car.Price < inputPrice && car.Brand == "Audi"
                             select car;
                dgvCars.DataSource = null;
                dgvCars.DataSource = result.ToList();
            }
            else
            {
                MessageBox.Show("Ошибка: Вы ввели не коректное значение. " + txtMaxPrice.Text);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var sortList = from car in cars
                           orderby car.Price
                           select car;
            dgvCars.DataSource = null;
            dgvCars.DataSource = sortList.ToList();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int price = 20000;
            int countCars = cars.Count(car => car.Price > price);
            if (countCars > 0)
            {
                MessageBox.Show("Количтево дорогих авто: " + countCars);
                var result = cars.Where(car => car.Price > price).ToList();
                dgvCars.DataSource = null;
                dgvCars.DataSource= result;
            }
            else
            {
                MessageBox.Show("Дорогих авто нету.");
                dgvCars.DataSource = null;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            switch (cmbOperation.SelectedIndex)
            {
                case 0:
                    var maxPrice = (from car in cars
                                   select car.Price).Max();
                    MessageBox.Show("Максимальная цена: " + maxPrice);
                    break;
                case 1:
                    var avaredPrice = cars.Average(car => car.Price);
                    MessageBox.Show("Средняя цена: " + avaredPrice);
                    break;
                case 2:
                    var sunPrice = cars.Sum(car => car.Price);
                    MessageBox.Show("Сумма цен: " + sunPrice);
                    break;
                default:
                    MessageBox.Show("Ошибка: Нету такого варианта");
                    break;
            }
        }

        private void btnBrandAge_Click(object sender, EventArgs e)
        {
            var result = from brand in brands
                         let age = DateTime.Now.Year - brand.FoundedYear
                         select new
                         {
                             brand.Name,
                             brand.Country,
                             brand.FoundedYear,
                             Age = age
                         };
            dgvBrands.DataSource = null;
            dgvBrands.DataSource = result.ToList();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            var result = brands
                         .GroupBy(brand => brand.Country)
                         .Select(group => new
                         {
                             Country = group.Key,
                             Brands = string.Join(", ", group.Select(brand => brand.Name))

                         });
            dgvBrands.DataSource = null;
            dgvBrands.DataSource = result.ToList();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var result = cars.Join(
                              brands,
                              car => car.Brand,
                              brand => brand.Name,
                              (car, brand) => new
                              {
                                  Model = car.Model,
                                  Price = car.Price,
                                  Brand = brand.Name,
                                  Country = brand.Country
                              }
            );
            dgvBrands.DataSource= result.ToList();
        }

        private void btnShowAll2_Click(object sender, EventArgs e)
        {
            dgvBrands.DataSource = null;
            dgvBrands.DataSource = brands;
        }

        private void btnGroupJoin_Click(object sender, EventArgs e)
        {
            var result = brands.GroupJoin(       
                         cars,
                         brand => brand.Name,
                         car => car.Brand,
                         (brand, machineCars) => new
                         {
                             Brand = brand.Name,
                             Country = brand.Country,
                             Cars = string.Join(", ", machineCars.Select(car => car.Model))
                         });
            dgvBrands.DataSource = null;
            dgvBrands.DataSource = result.ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAll_Click_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCheckPrice.Text, out decimal price))
            {
                bool checkPrice = cars.All(car => car.Price > price);
                dgvCars.DataSource = null;
                if (checkPrice)
                {
                    MessageBox.Show("Все автомобили дороже " + price);
                    var result = cars;
                    dgvCars.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Не все автомобили дороже " + price);
                    var result = cars.Where(car => car.Price <= price).ToList();
                    dgvCars.DataSource = result;
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Вы ввели не корректное значение.");
            }
            
        }

        private void btnAny_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAny.Text, out int year))
            {
                bool checkYear = brands.Any(brand => brand.FoundedYear > year);
                if (checkYear)
                {
                    MessageBox.Show("Есть компании основанные позже " + year);
                    var result = brands.Where(brand => brand.FoundedYear > year).ToList();
                    dgvBrands.DataSource = null;
                    dgvBrands.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Нету компаний основанные позже " + year);
                    dgvBrands.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Вы ввели не корректное значение.");
            }
            
        }
    }
}
