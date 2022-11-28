using Lab3.Model;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using Method = RestSharp.Method;

namespace Lab3
{
    public class Tests
    {
        private RestClient client;
        [SetUp]
        public void Setup()
        {
             client = new RestClient("https://restful-booker.herokuapp.com/");
        }
        [Test]
        public void POST_WhenAuth_ShouldBeSuccessResponse()
        {
            // arrange
            RestRequest request = new RestRequest("auth", Method.Post);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new Auth()
            {
                username = "admin",
                password = "password123"
            });
            // act
            RestResponse<AuthToken> response = client.Execute<AuthToken>(request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        [Test]
        public void GET_WhenGetBokingsWithId_ShouldBeSuccessResponse()
        {
            // arrange
            RestRequest request = new RestRequest("booking", Method.Get);

            // act
            RestResponse response = client.Execute<Booking>(request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void POST_WhenCreateBooking_ShouldBeSuccessResponse()
        {
            // arrange
            RestRequest request = new RestRequest("booking", Method.Post);

            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new Booking()
            {
                firstname = "James",
                lastname = "Brown ",
                totalprice = 200,
                depositpaid = true,
                bookingdates = new Bookingdates()
                {
                    checkin = "2018-01-01",
                    checkout = "2019-01-01"
                },
                additionalneeds = "Breakfast"
            });
            request.AddHeader("Accept", "application/json");
            // act
            RestResponse<Booking> response = client.Execute<Booking>(request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        }


        [Test]
        public void PUT_WhenUpdateBooking_ShouldBeSuccessResponse()
        {
            // arrange
            RestRequest request = new RestRequest("booking/60298", Method.Put);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new Booking()
            {
                firstname = "James",
                lastname = "Bond ",
                totalprice = 1000,
                depositpaid = true,
                bookingdates = new Bookingdates()
                {
                    checkin = "2018-03-01",
                    checkout = "2019-03-01"
                },
                additionalneeds = "007"
            });
            request.AddHeader("Accept", "application/json");

            client.Authenticator = new HttpBasicAuthenticator("admin", "password123");
            // act
            var response = client.Execute<Booking>(request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        }

        [Test]
        public void DELETE_WhenRemoveBookingsWithId_ShouldBeSuccessResponse()
        {
            // arrange
            RestRequest request = new RestRequest("booking/118457", Method.Delete);

            client.Authenticator = new HttpBasicAuthenticator("admin", "password123");
            // act
            RestResponse response = client.Execute(request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));

        }
        [Test]
        public void GET_WhenGetStatusCode_ShouldBeSuccessResponse()
        {
            // arrange
            RestClient client = new RestClient("https://api.punkapi.com/v2/");
            RestRequest request = new RestRequest("beers/random", Method.Get);

            // act
            RestResponse response = client.Execute<Beer>(request);

            // assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}