# MacroZone

## This Projects Goal
This projects goal is to create a simple to use, and practical way to create macros.

## Documentation For MacroZoneScript

### Making a file

Just make a file ending in .mz . mz standing for "macro zone"
Example
`myFirstMacro.mz`

### Writing a Macro

To write a macro, open up the file you created in your editor of choice, then write the commands you want. 

### Commands

`macro:keypress{keyYouWantToBePressed}`

Will press the key you enter in the brackets

`macro:sleep:{amountOfTimeMilisecconds}`

Will sleep the macro

# Build Instructions for Macro Zone

## Prerequisites

1. **Microsoft Visual Studio**:
   - Download and install [Microsoft Visual Studio](https://visualstudio.microsoft.com/).
   - Ensure the following components are installed:
     - **Desktop development with C++** workload
     - **Windows 10 SDK** 
   - Open Visual Studio and clone the repository.

2. **Git**:
   - Install [Git](https://git-scm.com/) to clone the repository if you haven't already.


---

## Build Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/macro-zone.git
   cd macro-zone
   ```

2. Open the project in Visual Studio:
   - Double-click the `MacroZone.sln` file in the project root.

3. Set the build configuration:
   - From the toolbar, select the appropriate configuration (e.g., `Release` or `Debug`).

4. Build the project:
   - Press `Ctrl + Shift + B` or go to **Build > Build Solution**.

---

## Adding Macro Zone to the PATH

1. Locate the output directory:
   - After building, the executable (`MacroZone.exe`) will be in the `bin` directory of your chosen configuration (e.g., `bin\Release`).

2. Add the directory to the PATH:
   - Open **System Properties**:
     - Press `Win + S`, search for "Environment Variables," and click **Edit the system environment variables**.
   - In the **System Properties** window, click the **Environment Variables** button.
   - In the **Environment Variables** window, find the `Path` variable under **System Variables** and click **Edit**.
   - Click **New** and paste the path to the `bin\Release` directory containing `MacroZone.exe`.
   - Click **OK** to close all windows.

3. Verify the PATH:
   - Open Command Prompt and type:
     ```bash
     MacroZone
     ```
   - The application should launch if added correctly.
