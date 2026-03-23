# Smart Student ID Card Generator

A desktop-based application that collects student information, captures a live webcam image using OpenCV, and stores structured records in a CSV file. The project demonstrates cross-language integration between C++ (backend processing) and C# (Windows Forms UI).

---

## Overview

This project is designed to simulate a basic student registration and ID generation system. It combines native C++ logic for data processing and image capture with a user-friendly C# Windows Forms interface.

The system captures student details along with a live image and stores everything in a structured format, making it suitable for small-scale academic or institutional use.

---

## Features

- Collect student information (Name, ID, Department, etc.)
- Capture live webcam image using OpenCV
- Save image automatically with student ID as filename
- Store all records in a `.csv` file
- Auto-create directory for storing images
- Cross-language integration (C++ + C#)
- Simple and clean Windows Forms interface

---

## Technologies Used

- **C++** (Core logic, OOP)
- **OpenCV** (Image capture)
- **C#** (Windows Forms UI)
- **.NET Framework**
- **File Handling (CSV)**

---

## How It Works

1. User enters student details through the interface
2. C++ backend processes and stores this data
3. Webcam is activated using OpenCV
4. User presses **'s'** to capture image
5. Image is saved in the `snapshots/` folder
6. Student data + image path is appended to a `.csv` file
7. C# Windows Form displays or interacts with the data

This demonstrates separation of concerns:
- **C++ → Processing & image handling**
- **C# → UI layer**

---

## Installation / Setup

### Prerequisites

- Visual Studio (with C++ & C# support)
- OpenCV installed and configured
- .NET Framework

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/smart-student-id-generator.git
