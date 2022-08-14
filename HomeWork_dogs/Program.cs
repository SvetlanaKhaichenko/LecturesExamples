 double distance = 10000;
 int FirstFriendSpeed = 1;
 int secondFrendSpeed = 2;
 int Dogspeed = 5;
 int friend = 2;
 double time = 0;
 int count = 0;


while ( distance > 10)
{
    if (friend == 1)
    {
        time = distance / (FirstFriendSpeed + Dogspeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFrendSpeed + Dogspeed);
        friend = 1;
    }
    distance = distance - ((FirstFriendSpeed + secondFrendSpeed) * time);
    count = count + 1;
}   
Console.WriteLine("Собака пробежит от одного друга к другому следующее количество раз ");
Console.WriteLine(count);