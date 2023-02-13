# ASP.NET Core Security
This is the repository for the LinkedIn Learning course ASP.NET Core Security. The full course is available from [LinkedIn Learning][lil-course-url].

![ASP.NET Core Security][lil-thumbnail-url] 

Software security is an important consideration when designing and developing web applications. While security breaches and threats can have serious consequences, there are steps you can take as a software developer to keep your applications safe. In this course, instructor Ervis Trupja explores techniques for securing and controlling access to your ASP.NET Core applications. Ervis begins by going over some of the most common types of attacks and how to protect yourself against them. Learn the skills you need to know to protect sensitive data in your applications using different strategies of authentication and authorization in ASP.NET Core.

## Instructions
This repository has branches for each of the videos in the course. You can use the branch pop up menu in github to switch to a specific branch and take a look at the course at that stage, or you can add `/tree/BRANCH_NAME` to the URL to go to the branch you want to access.

## Branches
The branches are structured to correspond to the videos in the course. The naming convention is `CHAPTER#_MOVIE#`. As an example, the branch named `02_03` corresponds to the second chapter and the third video in that chapter. 
Some branches will have a beginning and an end state. These are marked with the letters `b` for "beginning" and `e` for "end". The `b` branch contains the code as it is at the beginning of the movie. The `e` branch contains the code as it is at the end of the movie. The `main` branch holds the final state of the code when in the course.

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
	Commit changes using this command: git commit -m "some message"

## Installing
1. To use these exercise files, you must have the following installed:
	- [list of requirements for course]
2. Clone this repository into your local machine using the terminal (Mac), CMD (Windows), or a GUI tool like SourceTree.
3. [Course-specific instructions]


### Instructor

Ervis Trupja 
                            
Software Developer

                            

Check out my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/ervis-trupja).

[lil-course-url]: https://www.linkedin.com/learning/asp-dot-net-core-security-19041841?dApp=59033956
[lil-thumbnail-url]: https://media.licdn.com/dms/image/C560DAQFBrzLL9d6MUA/learning-public-crop_675_1200/0/1675902640846?e=2147483647&v=beta&t=RHhWZ35hMqf5PnO89YTlIgQNZV7tXnoN3IjpAG2IrsI
