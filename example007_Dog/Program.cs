int count = 0, 
    firsFriendSpeed = 1, secondFriendSpeed = 2, 
    dogSpeed = 5, friend = 2;
double time,distance = 10000;

while(distance > 10)
{
    if(friend == 1) 
    {
        time = distance / (firsFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firsFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
}
Console.Write("The Dog has began: ");
Console.WriteLine(count);
