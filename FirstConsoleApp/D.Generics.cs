// type lai nai as a argument pass garna sakne facility generics le dinxa
using System;

class Generics{
     public T Display< T> (T value ){
        Console.WriteLine($"value {value}");;
        return value;
     }
}