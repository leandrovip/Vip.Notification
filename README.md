
<h2 align="center"><strong>Vip.Notification</strong> - A simple toast alert notification for WinForms :coffee:</h2> 

<p align="center">
  <a href="https://raw.githubusercontent.com/leandrovip/Vip.Notification/master/LICENSE">
    <img src="https://img.shields.io/github/license/leandrovip/Vip.Notification" />
  </a>
  
  <a href="https://www.nuget.org/packages/Vip.Notification/">
    <img alt="Nuget" src="https://img.shields.io/nuget/dt/Vip.Notification?label=NuGet%20downloads">
  </a>
  
  <a href="https://www.nuget.org/packages/Vip.Printer/">
     <img alt="NuGet" src="https://img.shields.io/nuget/v/Vip.Notification.svg">
  </a>
</p>

<p align="center">
<img src="https://github.com/leandrovip/Vip.Notification/blob/master/assets/demo-nofitication.gif?raw=true" width="45%" />
</p>

# Get Started

## Requisites
- .NetFramework 4.8

## Step 0: Install via NuGet and declare using

```powershell
Install-Package Vip.Notification
```

```csharp
using Vip.Notification;
```

## Step 1: Call method Alert
```csharp
// Sucess
Alert.ShowSucess("My message sucess here");

// Information
Alert.ShowInformation("My message information here");

// Warning
Alert.ShowWarning("My message warning here");

// Error
Alert.ShowError("My message error here");

// Custom
// For custom is requisite 3 parameters
// Message - Message for print notification
// Image - Image for logo
// Color - Color for background 

Alert.ShowSucess("My custom message here", Image, Color.Blue);
```

License - MIT

:heart:

