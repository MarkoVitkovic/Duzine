# Size add or deduct
> Program that can add or deduct size. 

## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Setup](#setup)
* [Features](#features)
* [Status](#status)
* [Inspiration](#inspiration)
* [Contact](#contact)

## General info
Program is made in c#. I am so proud of this project as this is one of my first and hardest by then projects. So in this project you adding or deducting anz type of size (mm,cm,m,km) and as result you get one parsed size. Example, user input 1km + 30m and output is 1.03km or if he wants in m or cm he can choose.


## Screenshots
![](https://github.com/MarkoVitkovic/csh-sizeAddDeduct/blob/master/prva.jpg)

## Technologies
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)

## Setup
1.Open Visual Studio 2019.</br>

2.On the start window, choose Create a new project.</br>
![](https://docs.microsoft.com/en-us/visualstudio/get-started/media/vs-2019/create-new-project-dark-theme.png?view=vs-2019)</br>
3.On the Create a new project window, enter or type console in the search box. Next, choose C# from the Language list, and then choose Windows from the Platform list.</br>

* After you apply the language and platform filters, choose the Console App (.NET Core) template, and then choose Next.</br>
![](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/media/vs-2019/csharp-create-new-project-search-console-net-core-filtered.png?view=vs-2019)</br>
4.In the Configure your new project window, type or enter HelloWorld in the Project name box. Then, choose Create.</br>
![](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/media/vs-2019/csharp-name-your-helloworld-project.png?view=vs-2019)</br>


## Learn More


To learn C#, check out the [C# docs](https://docs.microsoft.com/en-us/dotnet/csharp/).

## Code Examples
Code:</br>
`if(saveFileDialog1.ShowDialog() == DialogResult.OK)`</br>
			`{`</br>
				`using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))`</br>
				`{`</br>
					`writer.Write(textBox1.Text);`</br>
				`}`</br>
			`}`</br>


## Features
List of features ready and TODOs for future development
* Add/deduct size
* Output size in mm,m,cm,km (choose!)

To-do list:
* none

## Status
Project is: _finished_

## Inspiration
My most loved project! I did this as my final exam.

## Contact
Created by [Marko Vitkovic](https://github.com/MarkoVitkovic) - feel free to contact me!







Program koji će omogućiti zbrajanje i oduzimanje udaljenosti zadanih različitim jedinicama (m, km, cm, mm). Na primjer, da korisnik može napisati „1 km + 30 m“ i da kao rezultat dobije „1.03 km“ ili da za „1 km – 920 m“ kao rezultat dobije „80 m“. Treba omogućiti da se rezultat prikaže u jedinicama koje korisnik zada te da se operacija može izvesti s proizvoljnim brojem udaljenosti.

Program that can add or deduct sizes from user input. And return that as a result. Check code to see what is need for this! Thanks!


![](https://github.com/MarkoVitkovic/Size_add-deduct/blob/master/prva.jpg)
























