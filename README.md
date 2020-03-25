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
1.Open your Visual Studio Environment and Click File->New Project</br>
![](http://csharp.net-informations.com/gui/img/new-project.png)</br>
2.Then you will get a New Project Dialogue Box asking in which language you want to create a new project.</br>
![](http://csharp.net-informations.com/gui/img/visual-studio.png)</br>
3.Select Visual C# from the list, then you will get the following screen.</br>
![](http://csharp.net-informations.com/gui/img/form-control.png)</br>
4.Now you can add controls in your Form Control.</br>


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
* Create new file
* Open existing file
* Edit new or existing file

To-do list:
* Tool box
* can open more formats

## Status
Project is: _finished_

## Inspiration
First csh GUI program from me.

## Contact
Created by [Marko Vitkovic](https://github.com/MarkoVitkovic) - feel free to contact me!







Program koji će omogućiti zbrajanje i oduzimanje udaljenosti zadanih različitim jedinicama (m, km, cm, mm). Na primjer, da korisnik može napisati „1 km + 30 m“ i da kao rezultat dobije „1.03 km“ ili da za „1 km – 920 m“ kao rezultat dobije „80 m“. Treba omogućiti da se rezultat prikaže u jedinicama koje korisnik zada te da se operacija može izvesti s proizvoljnim brojem udaljenosti.

Program that can add or deduct sizes from user input. And return that as a result. Check code to see what is need for this! Thanks!


![](https://github.com/MarkoVitkovic/Size_add-deduct/blob/master/prva.jpg)
























