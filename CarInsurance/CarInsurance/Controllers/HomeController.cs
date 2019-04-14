using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=DESKTOP-AR78C21\SQLEXPRESS;Initial Catalog=CarInsurance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetQuote(string FirstName,string LastName, string EmailAddress, DateTime DateOfBirth, int CarYear, string CarMake, string CarModel, int DUI, int TicketNumber, string FullOrLiability)
        {
            double Quote;
            int baseAmount = 50;
            if (DateTime.Now.Year - DateOfBirth.Year < 18) { Quote = baseAmount + 100; }
            else if (DateTime.Now.Year - DateOfBirth.Year < 25) { Quote = baseAmount + 25; }
            else if (DateTime.Now.Year - DateOfBirth.Year > 100) { Quote = baseAmount + 25; }
            else { Quote = baseAmount; }

            if (CarYear < 2000) { Quote += 25; }
            if(CarYear > 2015) { Quote += 25; }
            if (CarMake == "Porsche") { Quote += 25; }
            if (CarMake == "Porsche" && CarModel == "911") { Quote += 25; }

            Quote = 10 * TicketNumber + Quote;

            if (DUI > 0) { Quote = Quote * 1.25; }
            if (FullOrLiability == "full coverage" || FullOrLiability == "Full Coverage") { Quote = Quote * 1.5; }

            string queryString = @"INSERT INTO GetQuote (FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, DUI, TicketNumber, FullOrLiability, Quote) VALUES
                                   (@FirstName, @LastName, @EmailAddress, @DateOfBirth, @CarYear, @CarMake, @CarModel, @DUI, @TicketNumber, @FullOrLiability, @Quote)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                command.Parameters.Add("@LastName", SqlDbType.VarChar);
                command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime);
                command.Parameters.Add("@CarYear", SqlDbType.Int);
                command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                command.Parameters.Add("@DUI", SqlDbType.Int);
                command.Parameters.Add("@TicketNumber", SqlDbType.Int);
                command.Parameters.Add("@FullOrLiability", SqlDbType.VarChar);
                command.Parameters.Add("@Quote", SqlDbType.Float);

                command.Parameters["@FirstName"].Value = FirstName;
                command.Parameters["@LastName"].Value = LastName;
                command.Parameters["@EmailAddress"].Value = EmailAddress;
                command.Parameters["@DateOfBirth"].Value = DateOfBirth;
                command.Parameters["@CarYear"].Value = CarYear;
                command.Parameters["@CarMake"].Value = CarMake;
                command.Parameters["@CarModel"].Value = CarModel;
                command.Parameters["@DUI"].Value = DUI;
                command.Parameters["@TicketNumber"].Value = TicketNumber;
                command.Parameters["@FullOrLiability"].Value = FullOrLiability;
                command.Parameters["@Quote"].Value = Quote;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            return View("Sucess");

            //using (CarInsuranceEntities db = new CarInsuranceEntities())
            //{
            //    var getquote = new GetQuote();
            //    getquote.FirstName = FirstName;
            //    getquote.LastName = LastName;
            //    getquote.EmailAddress = EmailAddress;
            //    getquote.DateOfBirth = DateOfBirth;
            //    getquote.CarYear = CarYear;
            //    getquote.CarMake = CarMake;
            //    getquote.CarModel = CarModel;
            //    getquote.DUI = DUI;
            //    getquote.TicketNumber = TicketNumber;
            //    getquote.FullOrLiability = FullOrLiability;
            //    getquote.Quote = Quote;
            //    db.GetQuotes.Add(getquote);
            //    db.SaveChanges();
            //    }
            //return View("Sucess");
        }




        public ActionResult Admin()
        {
            //using (CarInsuranceEntities db = new CarInsuranceEntities())
            //{
            //    var getquotes = db.GetQuotes;
            //    var getquoteVms = new List<GetquoteVm>();
            //    foreach (var getquote in getquotes)
            //    {
            //        var getquoteVm = new GetquoteVm();
            //        getquoteVm.FirstName = getquote.FirstName;
            //        getquoteVm.LastName = getquote.LastName;
            //        getquoteVm.EmailAddress = getquote.EmailAddress;
            //        getquoteVm.Quote = Convert.ToDouble(getquote.Quote);
            //        getquoteVms.Add(getquoteVm);
            //    }
            //    return View(getquoteVms);
            //}
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, Quote From GetQuote";
            List<GetQuote> getquotes = new List<GetQuote>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var getquote = new GetQuote();
                    getquote.Id = Convert.ToInt32(reader["Id"]);
                    getquote.FirstName = reader["FirstName"].ToString();
                    getquote.LastName = reader["LastName"].ToString();
                    getquote.EmailAddress = reader["EmailAddress"].ToString();
                    getquote.Quote = Convert.ToDouble(reader["Quote"]);
                    getquotes.Add(getquote);
                }

                var getquoteVms = new List<GetquoteVm>();
                foreach (var getquote in getquotes)
                {
                    var getquoteVm = new GetquoteVm();
                    getquoteVm.FirstName = getquote.FirstName;
                    getquoteVm.LastName = getquote.LastName;
                    getquoteVm.EmailAddress = getquote.EmailAddress;
                    getquoteVm.Quote = Convert.ToDouble(getquote.Quote);
                    getquoteVms.Add(getquoteVm);
                }
                return View(getquoteVms);
                //return View(getquotes);
            }




        }
        
    }
}