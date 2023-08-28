using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AstroClient
{

    // Define the service contract interface
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AstroClient
{

    // Define the service contract interface
    // It connects the client application to the server application's methods.

    [ServiceContract]
    internal interface IAstroContract
    {
        // Declare the Method contract that
        [OperationContract]
        double StarVelocity(double observedWavelength, double restWavelength);

        [OperationContract]
        double StarDistance(double arsecondsAngle);

        [OperationContract]
        double TemperatureInKelvin(double celcius);

        [OperationContract]
        double EventHorizon(double blackholeMass);

    }
}
    [ServiceContract]
    internal interface IAstroContract
    {
        // Declare the Method contract that
        [OperationContract]
        double StarVelocity(double observedWavelength, double restWavelength);

        [OperationContract]
        double StarDistance(double arsecondsAngle);

        [OperationContract]
        double TemperatureInKelvin(double celcius);

        [OperationContract]
        double EventHorizon(double blackholeMass);

    }
}
