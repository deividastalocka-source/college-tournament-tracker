# College Tournament Tracker (C# Windows Forms Application)

**Version:** 1.0
**Author:** Deividas Talocka
**Date:** 02/02/2023

A C# Windows Forms application designed to help colleges manage ongoing tournaments efficiently. The program tracks both **team and individual events**, calculates points, and displays **leaderboards** for participants and teams. It also includes an **auto-save feature** to preserve user data.

---

## Features

* Input participant names and team points.
* Validate inputs (no negative numbers or letters in numeric fields).
* Auto-calculation of awards based on points (e.g., Gold, Silver, Bronze).
* Displays:

  * Event lists
  * Team points
  * Individual points
  * Team and individual leaderboards
* Simple, user-friendly GUI with multiple forms:

  * **Main Menu**
  * **Team Events**
  * **Individual Events**
  * **Leaderboards**
* Auto-save to retain previous session data.
* Portable and runs from a USB stick.


## Requirements

**Inputs:**

* Participant names
* Team points (integer only, no negatives)

**Processes:**

* Calculate total points per team and individual
* Determine awards based on points

**Outputs:**

* Display events
* Display participants and teams
* Display team and individual leaderboards with points and awards

**File Handling:**

* Load previously saved data
* Save current session automatically

**Interface:**

* Simple GUI with easy navigation
* Multiple forms with buttons to navigate between forms
* Output is read-only

---

## GUI Overview

1. **Main Menu:** Navigate to different sections of the application.
2. **Team Events Form:** Enter points for each team in each event.
3. **Individual Events Form:** Enter individual participant points.
4. **Leaderboard Form:** Display top three teams and individuals per event.

**GUI Components Used:**

* Panels & Table Layout Panels for clean structure
* Buttons for navigation
* NumericUpDown controls to validate numeric input
* Labels for dynamic display of points and awards

---

## Technical Details

* **Language:** C#
* **Platform:** Windows Forms (WinForms)
* **Development IDE:** Visual Studio (optional for users; project can run with `.cs` files if compiled manually)
* **Data Storage:** Auto-save via application settings for persistent state
