using System.Media;
using ProgramData;
using System;

// Replace "Voice/greeting.wav" with the actual path to your recorded voice file
SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\ProgramData\\ProgramData\\ProgramData\\voice\\output.wav");
player.PlaySync();


//Console.WriteLine(" ")
 Logo logo = new Logo();
logo.DisplayLogo("Your Logo Here");
Console.WriteLine("Audio play successful");
Console.ReadLine();
