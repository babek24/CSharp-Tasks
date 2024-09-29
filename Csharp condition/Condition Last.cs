// Task 1
int number = 4;
if (number % 2 == 0 && number != 0)
{
    Console.WriteLine("Number is Even");
}
else
{
    Console.WriteLine("Number is Odd");
}

string result = (number % 2 == 0 && number != 0) ? "Number is even" : "Number is odd";
Console.WriteLine(result);
//-----------------------------------------------------------------------------------------

// Task 2
double mebleg = 200;
double endrim1 = mebleg - mebleg * 0.1;
double endrim2 = mebleg - mebleg * 0.15;
double endrim3 = mebleg - mebleg * 0.2;

if (mebleg >= 100 && mebleg<200)
{
    Console.Write("siz 10% endrim elde etdiniz, Odenecek mebleg: ");
    Console.WriteLine(endrim1);
}
else if (mebleg >=200 && mebleg<300)
{
    Console.Write(" siz 15% endrim elde etdiniz, Odenecek mebleg: ");
    Console.WriteLine(endrim2);
}
else if (mebleg >= 300)
{
    Console.Write(" siz 20% endrim elde etdiniz, Odenecek mebleg: ");
    Console.WriteLine( endrim3);
}
else
{
    Console.WriteLine("Endrim elde etmek ucun en azi 200 TL alis veris etmelisiz ");
}


//----------------------------------------------------------------------------------

// Task 3
double BMI = 24;
if (BMI < 18.5)
{
    Console.WriteLine("Underweight");
}
else if (BMI >= 18.5 && BMI <= 24.9)
{
    Console.WriteLine("Normal weight");
}
else if(BMI >= 25 && BMI <= 29.9)
{
    Console.WriteLine("Overweight");
}
else
{
    Console.WriteLine("Obesity");
}


//--------------------------------------------
// Task 4

int RandomIntNumber = 5;

if (RandomIntNumber == 0)
{
    Console.WriteLine("Entered Number is Zero");
}
else if(RandomIntNumber %5==0 && RandomIntNumber % 11 == 0)
{
    Console.WriteLine("Your number is divisible by 5 and 11");
}
else
{
    Console.WriteLine("Your number does not match the rule");
}

//----------------------------------------------------------------
//Task 5
string cartype = ("taxi");
double time = 2;
double TaxiPrice = 5;
double BusPrice = 6;
double TruckPrice = 6.5;
double ExtraTimeTaxi = TaxiPrice*time + (time-1)*(time*0.2);
double ExtraTimeBus = BusPrice*time + (time-1)*(time*0.215);
double ExtraTimeTruck = TruckPrice*time + (time-1)*(time * 0.25);
if (cartype == "taxi" && time <= 1)
{
    Console.WriteLine("5");
}
else if (cartype == "taxi" && time > 1)
{
    Console.WriteLine(ExtraTimeTaxi);
}
else if (cartype == "bus" && time <= 1)
{
    Console.WriteLine("6");
}
else if (cartype == "bus" && time > 1)
{
    Console.WriteLine(ExtraTimeBus);
}
else if (cartype == "truck" && time <= 1)
{
    Console.WriteLine("6.5");
}
else if (cartype == "truck" && time > 1)
{
    Console.WriteLine(ExtraTimeTruck);
}
else
{
    Console.WriteLine("..");
}