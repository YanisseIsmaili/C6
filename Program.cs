﻿/*using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelloWorld_Exercice.HelloWorld());
        }
    }
}
///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoIntegers_Exercice.AddTwoIntegers(1, 2));
            Console.WriteLine(AddTwoIntegers_Exercice.AddTwoIntegers(10, 5));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsOdd_Exercice.IsOdd(2));
            Console.WriteLine(IsOdd_Exercice.IsOdd(11));
            Console.WriteLine(IsOdd_Exercice.IsOdd(30));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CSharpDiscovery.Quest01.SetPiValue_Exercice.SetPiValue(0));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpellItBackwards_Exercice.SpellItBackward("helloworld"));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            Console.WriteLine(GetStringSize_Exercice.GetStringSize("helloworld"));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            Console.WriteLine(Capitalize_Exercice.Capitalize("helloworld"));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            Console.WriteLine(RemoveSpaces_Exercice.RemoveSpaces("  helloworld  "));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            string[] table = { "hello", "world" };
            Console.WriteLine(ConcatEverything_Exercice.ConcatEverything(table));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            Console.WriteLine(ContainsSpecificSubstring_Exercice.ContainsSpecificSubstring("helloworld", "hello"));
            Console.WriteLine(ContainsSpecificSubstring_Exercice.ContainsSpecificSubstring("helloworld", "monde"));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            Console.WriteLine(BeginsWithSpecificCharacter_Exercice.BeginsWithSpecificCharacter("helloworld", 'h'));
            Console.WriteLine(BeginsWithSpecificCharacter_Exercice.BeginsWithSpecificCharacter("helloworld", 'w'));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest01;
using CSharpDiscovery.Models;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextTrafficLightColor_Exercice.GetNextTrafficLightColor(TrafficLightColor.Red));
            Console.WriteLine(NextTrafficLightColor_Exercice.GetNextTrafficLightColor(TrafficLightColor.Orange));
            Console.WriteLine(NextTrafficLightColor_Exercice.GetNextTrafficLightColor(TrafficLightColor.None));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using CSharpDiscovery.Quest02;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DisplayDateWithoutTime_Exercice.DisplayDateWithoutTime(new DateTime(2021, 1, 14)));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using CSharpDiscovery.Quest02;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new DateTime(2021, 02, 01, 12, 0, 0, 0);
            var end = new DateTime(2021, 02, 01, 18, 0, 0, 0);
            Console.WriteLine(DifferenceInMinutes_Exercice.DifferenceInMinutes(start, end));

        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest02;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FromStringToDateTime_Exercice.FromStringToDateTime("21/12/2021 18:33"));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using CSharpDiscovery.Quest02;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tab = new int[5] { 99, 98, 92, 97, 95 };
            var tab2 = new int[5] { 50, 54, 85, 47, 2 };
            Console.WriteLine(ContainsThisValue_Exercice.ContainsThisValue(tab, 97));
            Console.WriteLine(ContainsThisValue_Exercice.ContainsThisValue(tab2, 51));
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////:/
/////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using CSharpDiscovery.Quest02;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 3, 24, 13, 4, 40 };
            Console.WriteLine(string.Join(", ", SortTable_Exercice.SortTable(array)));
        }
    }
}


 using System;
using CSharpDiscovery.Quest03;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var poi = new PointOfInterest();
            Console.WriteLine(poi.Latitude);
            Console.WriteLine(poi.Longitude);
            Console.WriteLine(poi.Name);

            Console.WriteLine(PointOfInterest.GoogleMapsUrlTemplate);
        }
    }
}

using System;
using CSharpDiscovery.Quest03;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var DefaultPoint = new PointOfInterest();
            Console.WriteLine(DefaultPoint.Name);
            Console.WriteLine(DefaultPoint.Latitude);
            Console.WriteLine(DefaultPoint.Longitude);

            var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);
            Console.WriteLine(ParisCampus.Name);
            Console.WriteLine(ParisCampus.Latitude);
            Console.WriteLine(ParisCampus.Longitude);
        }
    }
}



using System;
using CSharpDiscovery.Quest03;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var DefaultPoint = new PointOfInterest();
            Console.WriteLine(DefaultPoint.GetGoogleMapsUrl());

            var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);
            Console.WriteLine(ParisCampus.GetGoogleMapsUrl());
        }
    }
}
*/
using System;
using CSharpDiscovery.Quest03;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var DefaultPoint = new PointOfInterest();
            Console.WriteLine(DefaultPoint.GetGoogleMapsUrl());

            var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);
            Console.WriteLine(ParisCampus.GetGoogleMapsUrl());
        }
    }
}
