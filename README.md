# Leetcode-CSharp-Template
<a href="https://docs.microsoft.com/en-us/dotnet/csharp/" target="_blank" rel="noreferrer"><img align="center" src="https://raw.githubusercontent.com/danielcranney/readme-generator/main/public/icons/skills/csharp-colored.svg" width="36" height="36" alt="C#" /></a>
Use this template to showcase your leetcode progress, OOP skills and input parsing via github.

**Description**
------------------
😡 I created this template because I was tired of seeing my github activity decay while practicing data structures and alogrithms.

I've included <em>[Problem 1 Two Sum](https://leetcode.com/problems/two-sum/)</em> with the template to showcase the entire process of implementing a question within the console app.

- Use this repo as a way to practice leetcode while keeping your github active.
- Use this repo as a way to practice input parsing.
- Use this repo as a way to practice OOP with SOLID in mind utilizing the built in interfaces I've created and examples I've set forth.

</br><p align = "center"> ⚠️⚠️⚠️ </p>
Due to the nature of accepting input this template gives you the responsiblity of going a step further to actually handle the input parsing.
Go as hard as you want with error checking. For sanity I try to assume input will be formatted correctly against the constraints and fail back to the main menu with improper input. This decision however is left you as the one creating the parsing and input retrieval.

**Usage**
-----------
Use this repo as a template to create your own fresh repository.

</br>**<em>[Common Folder](https://github.com/rayraydejesus/LeetCode-CSharp-Template/blob/main/Common/)</em>**
- Contains an interface and abstract class to dervive you leetcode problems from.
- Includes a prompts file to handle basic error and input prompting.
  
</br>**<em>[Problems Folder](https://github.com/rayraydejesus/LeetCode-CSharp-Template/blob/main/Problems/)</em>** 
- Where you can store the folders for each question(feature).
- In addition there is a [Problems Index File](https://github.com/rayraydejesus/LeetCode-CSharp-Template/blob/main/Problems/ProblemsIndex.cs) where you should register you problem to the existing switch case.
- The switch case is used to create a constant hash map based on how c# compiles code. This also prevents creating every problem set object in memory at application startup... Think of it as lazy loading our problems.

<strong>CHEERS! 🍻</strong>
-------
