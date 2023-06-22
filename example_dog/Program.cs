int count = 0, firstFriendSpeed = 1, 
secondFriendSpeed = 2, dogSpeed = 5, frend = 2;
double distance = 11000, time = 0;
while (distance > 10) {
    if (frend == 2) {
        time = distance / (secondFriendSpeed + dogSpeed);
        frend = 1;
        count++;
    }
    if (frend == 1) {
        time = distance / (firstFriendSpeed + dogSpeed);
        frend = 2;
        count++;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
}

Console.Write("Собака пробежит: ");
Console.Write(count);
Console.Write(" раз. ");
