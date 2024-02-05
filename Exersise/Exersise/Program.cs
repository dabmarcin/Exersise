string name = "Ewa";
char sex = 'f';
int age = 25;

if (sex == 'f' && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex != 'f' && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
