<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a name="readme-top"></a>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->

[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/GiovanniBraconi/MarsRover">
    <img src="images/marsRover.jpg" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Mars Rover</h3>

  <p align="center">
    API that translates the commands sent from earth to instructions that are understood by the rover.
    <br />
    <a href="https://github.com/GiovanniBraconi/MarsRover"><strong>Explore the docs »</strong></a>
    <br />
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->

## About The Project

You’re part of the team that explores Mars by sending remotely controlled vehicles to the surface of the planet. Develop
an API that translates the commands sent from earth to instructions that are understood by the rover.

Requirements

    • You are given the initial starting point (x,y) of a rover and the direction (N,S,E,W) it is facing.
    • The rover receives a character array of commands.
    • Implement commands that move the rover forward/backward (f,b).
    • Implement commands that turn the rover left/right (l,r).
    • Implement wrapping from one edge of the grid to another. (planets are spheres after all)
    • Implement obstacle detection before each move to a new square. If a given sequence of commands encounters an obstacle, the rover moves up to the last possible point, aborts the sequence and reports the obstacle.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Built With

* [![dotnet][dotnet.com]][dotnet-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- GETTING STARTED -->

## Getting Started

If you just want to run the program you can download and double-click the self-contained [executable](https://github.com/GiovanniBraconi/MarsRover/blob/master/MarsRover.exe) file. If you also want
to modify and build the code follow the instructions below.

### Prerequisites

* Install
  [.NET](https://dotnet.microsoft.com/en-us/download)

### Installation

* Clone the repo
   ```sh
   git clone https://github.com/GiovanniBraconi/MarsRover.git
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->

## Usage

After running the application the rover object position is initialized to (0,0) on the grid, with N (North) as the
facing direction. The grid is a 3*3 grid (the max/min x and y are 1/-1) where 3 random positions are filled with an
obstacle. The rover can be moved using the following
commands given on the same line with no spaces in between:

    f: move forward
    b: move backward
    l: turn facing direction left
    r: turn facing direction right

So for example the following command:

   ```sh
   frf
 ```           

would move the rover from (0,0) to (0,1), change the facing direction to E (East) and move the rover to (1,1).

   ```
  Rover position: (0,1) 
  Rover direction: E
  Rover position: (1,1)
 ```           

Since the grid is wrapped around a planet the rover can move from one edge of the grid to the other, so for example the
following command:

   ```sh
 ff
 ```           

would move the rover from (0,0) to (0,1) and then to (0,-1).

   ```
 Rover position: (0, 1)
 Rover position: (0, -1)
   ```

Finally remember that the rover can't move to a position that is occupied by an obstacle; if for example an obstacle is
in (0,-1) the following command:

   ```sh
 bb
 ```

would just report the obstacle without moving the rover from (0,0).

   ```
 Obstacle detected at: (0, -1)
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>






<!-- LICENSE -->

## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->

## Contact

Your Name - giov.braconi@gmail.com

Project Link: [https://github.com/GiovanniBraconi/MarsRover](https://github.com/GiovanniBraconi/MarsRover)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

****

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[contributors-shield]: https://img.shields.io/github/contributors/github_username/repo_name.svg?style=for-the-badge

[contributors-url]: https://github.com/github_username/repo_name/graphs/contributors

[forks-shield]: https://img.shields.io/github/forks/github_username/repo_name.svg?style=for-the-badge

[forks-url]: https://github.com/github_username/repo_name/network/members

[stars-shield]: https://img.shields.io/github/stars/github_username/repo_name.svg?style=for-the-badge

[stars-url]: https://github.com/github_username/repo_name/stargazers

[issues-shield]: https://img.shields.io/github/issues/github_username/repo_name.svg?style=for-the-badge

[issues-url]: https://github.com/github_username/repo_name/issues

[license-shield]: https://img.shields.io/github/license/github_username/repo_name.svg?style=for-the-badge

[license-url]: https://github.com/github_username/repo_name/blob/master/LICENSE.txt

[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555

[linkedin-url]: https://www.linkedin.com/in/giovanni-braconi/

[product-screenshot]: images/screenshot.png

[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white

[Next-url]: https://nextjs.org/

[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB

[React-url]: https://reactjs.org/

[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D

[Vue-url]: https://vuejs.org/

[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white

[Angular-url]: https://angular.io/

[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00

[Svelte-url]: https://svelte.dev/

[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white

[Laravel-url]: https://laravel.com

[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white

[Bootstrap-url]: https://getbootstrap.com

[dotnet.com]: https://img.shields.io/badge/.NET-0769AD?style=for-the-badge&logo=C-Sharp&logoColor=white

[dotnet-url]: https://dotnet.microsoft.com/en-us/
