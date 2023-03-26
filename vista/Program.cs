using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jS3xRdEZiX3pbc3JURw==;Mgo+DSMBPh8sVXJ0S0J+XE9AflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdEdhW3xfdnFQRWdUUA==;ORg4AjUWIQA/Gnt2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdhW31dcXJQQ2RcUUU=;MTE4NDIzMEAzMjMwMmUzNDJlMzBjZ2RXTm5CL1lXRC9aNGhHbzk3NnA5WHRKZXdLaFljeUV1a2g0S2ZXSjNJPQ==;MTE4NDIzMUAzMjMwMmUzNDJlMzBBd3ljMEJWcVJjTlp0Sy85L0dIMDdhNytmTUd1MDhPK0lPN1JLNHZCUFZRPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVhW31cc3VTQ2VZUUR3;MTE4NDIzM0AzMjMwMmUzNDJlMzBldTVIdGhoRmlEUHh6RjZSSzA5MTNCakd6ZU1BMUxHOTg0eEd2NU91UnVZPQ==;MTE4NDIzNEAzMjMwMmUzNDJlMzBCQklzYnV5OUtPUHNBdWI2QXF3djVkd3FSOXRERndIZFpzWHFpRkJJYnlRPQ==;Mgo+DSMBMAY9C3t2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdhW31dcXJQQ2VUVEU=;MTE4NDIzNkAzMjMwMmUzNDJlMzBNWkJaamN0VEM3VnJFNWdDdUM3R0JxUFdkSzJZQkJpdVVhQ1B4TzJMU2RBPQ==;MTE4NDIzN0AzMjMwMmUzNDJlMzBrbmtlZUJsc0I2czdXUnNBMDVkL0xBQ3hLeXZsMFJCckJoRlNjNE5mc2JjPQ==;MTE4NDIzOEAzMjMwMmUzNDJlMzBldTVIdGhoRmlEUHh6RjZSSzA5MTNCakd6ZU1BMUxHOTg0eEd2NU91UnVZPQ==");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
