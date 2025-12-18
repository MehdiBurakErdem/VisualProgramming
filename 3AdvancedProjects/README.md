\# 🧠 Matching Game



A simple and fun \*\*memory-based game\*\* developed with \*\*C# WinForms\*\*.  

Train your memory, progress through levels, and challenge yourself with no upper limit.



---



\## 🔧 Setup



This project uses a \*\*lightweight SQLite database\*\*.



\### Requirements

\- Visual Studio

\- .NET Framework (WinForms)



\### Steps

1\. Install \*\*System.Data.SQLite\*\* via \*\*NuGet\*\*

2\. From \*\*Extensions\*\*, install:  

&nbsp;  \*\*SQLite and SQL Server Compact Toolbox (by ErikEJ)\*\*

3\. Restart Visual Studio



After these steps, the project will be ready to run.



> A full SQL Server can also be used, but SQLite was preferred since the project does not require a complex database structure.



---



\## 🎨 UI Framework



This project uses the \*\*Bunifu UI Framework\*\* (14-day trial version).



\- Bunifu is used only for UI/UX enhancements

\- You can redesign the project using \*\*standard Visual Studio toolbox controls\*\* if preferred



---



\## 🕹️ Game Modes



\*\*Matching Game\*\* consists of \*\*two main game modes\*\*.  

Each user has a \*\*level\*\*, and progress is tracked based on level advancement.



\### 🔹 Levels 1–9 (Warm-up)

\- Classic card matching gameplay

\- Find \*\*two identical cards\*\*

\- Designed to warm up your memory



\### 🔹 Level 9 → Infinity (Memory Challenge)

\- Numbers are shown in a specific order

\- You must enter the numbers \*\*in the correct sequence\*\*

\- \*\*No level limit\*\*

\- The limit is \*\*your memory\*\*



---



\## 👤 User System



\- Each user has an individual level

\- User levels are stored in the database

\- You can view:

&nbsp; - Total number of users

&nbsp; - Current levels of users



---



\## 🎯 Goal



Improve your memory, beat your own limits, and see how far you can go.



---



\## 📌 Notes



\- Bunifu UI is optional and not required for core functionality

\- The project uses a \*\*light and simple database design\*\*

\- Easily extendable with new game modes or scoring systems



