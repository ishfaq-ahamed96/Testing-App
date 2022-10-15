// See https://aka.ms/new-console-template for more information
var counter = 0;
var max = 10;
while(counter++ <= max -1){
    Console.WriteLine("This counter is:" +counter);
    if(counter == 10)
        Console.WriteLine("Counter Ended in :" +counter);

    System.Threading.Thread.Sleep(
    (int)System.TimeSpan.FromSeconds(1).TotalMilliseconds);
}
