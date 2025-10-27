# Phonebook 2015

**Phonebook 2015** is a simple desktop application built with **Visual Basic .NET** for managing and storing contact information.  
It uses a local **Microsoft Access (MDB)** database to save records such as names, phone numbers, and other contact details.

---

## 📋 Features

- Add, edit, and delete contact records  
- Search and filter existing entries  
- View contact details in an intuitive interface  
- Data stored locally using an Access database (`Database.mdb`)  
- Lightweight and fast Windows Forms UI  

---

## 🧰 Technologies Used

- **Language:** Visual Basic .NET (VB.NET)  
- **Framework:** .NET Framework 4.x  
- **Database:** Microsoft Access (`.mdb`)  
- **IDE:** Visual Studio (tested on VS 2015 and newer)

---

## 🗂️ Project Structure

```
Phonebook 2015/
├── Phonebook.sln                  # Visual Studio solution file
├── Phonebook/
│   ├── App.config
│   ├── Phonebook.vbproj           # VB.NET project file
│   ├── Database.mdb               # Access database for storing contacts
│   ├── Form1.vb / Form2.vb        # Windows Forms (UI logic)
│   ├── DatabaseDataSet.*          # Dataset and schema files
│   ├── My Project/                # Auto-generated Visual Studio files
│   └── bin/Debug/                 # Compiled output (EXE, PDB, etc.)
└── .vs/                           # Visual Studio cache files
```

---

## ▶️ How to Run

1. Open the project in **Visual Studio 2015 or later**.  
2. Restore dependencies if prompted.  
3. Build and run the solution (`Ctrl + F5`).  
4. The application will launch and automatically connect to the included `Database.mdb`.

---

## 💾 Database Details

The Access database (`Database.mdb`) contains a single table for storing contacts.  
Common fields include:

| Field Name | Description |
|-------------|-------------|
| `ID`        | Auto-generated unique identifier |
| `Name`      | Full name of the contact |
| `Phone`     | Contact number |
| `Email`     | Email address (if applicable) |
| `Address`   | Optional address field |

---

## 🧑‍💻 Developer Notes

- Ensure Microsoft Access Database Engine (OLEDB provider) is installed on your system.  
- The database file should remain in the same directory as the executable.  
- You can customize the form layout or add validation logic in `Form1.vb` and `Form2.vb`.

---

## 📄 License

This project is provided for educational and demonstration purposes.  
You may modify and distribute it freely with attribution.

---

**Author:** Unknown (2015 release)  
**Updated README:** 2025 by ChatGPT
