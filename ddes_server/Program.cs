using DDES_Server.Controllers;
using DDES_Server.Interfaces;
using DDES_Server.Models;
using DDES_Server.Server;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace DDES_Server
{
    public static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SampleData.CreateData();

            Console.WriteLine(JsonSerializer.Serialize( ParentController.GetAll() ));

            _ = new AsynchronousSocketListener();
        }
    }
}