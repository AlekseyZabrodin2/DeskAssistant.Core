# DeskAssistant.Core

**Core Task and Calendar Management System**

## 📋 Description

DeskAssistant.Core is the core library of a task management system, providing basic models, services, and contracts for working with calendar tasks, their prioritization, and Telegram notifications.

## 🏗️ Project Architecture

### Solution Structure

```
DeskAssistant.Core/
├── Extensions/           # Extensions
│   └── EnumExtensions.cs
├── Models/              # Data Models
│   ├── CalendarTaskEntity.cs    # Database Entity
│   ├── CalendarTaskModel.cs     # DTO Model
│   ├── PrioritiesLevelEnum.cs   # Priority Levels
│   └── TaskStatusEnum.cs        # Task Statuses
├── Protos/              # gRPC Contracts
│   └── task.proto
└── Services/            # Services
    ├── ITaskService.cs                 # Task Service
    └── ITelegramNotificationService.cs # Telegram Notification Service
```

## 📦 Core Components

### Models

- **CalendarTaskEntity** - database storage entity
- **CalendarTaskModel** - data transfer object between layers
- **PrioritiesLevelEnum** - task priority levels enumeration
- **TaskStatusEnum** - task execution statuses enumeration

### Services

- **ITaskService** - interface for task operations (CRUD)
- **ITelegramNotificationService** - interface for sending Telegram notifications

### Extensions

- **EnumExtensions** - utility methods for working with enumerations

### gRPC Contracts

- **task.proto** - Protocol Buffers contracts for gRPC API

## 🚀 Features

- ✅ Calendar task management
- 🎯 Task prioritization
- 📊 Execution status tracking
- 🔔 Telegram notifications
- 🌐 gRPC API for client applications

## 🛠️ Technologies

- **C#** / .NET
- **gRPC** - for inter-service communication
- **Protocol Buffers** - data serialization
- **Telegram Bot API** - notification system

## Building the DeskAssistant.Core NuGet Package

1. Navigate to the library folder:
```bash
cd D:\Develop\DeskAssistant.Core
````

2. Build the package:

```bash
dotnet pack --configuration Release
```

3. Remove the old source:

```bash
dotnet nuget remove source LocalDeskAssistant
```

4. Add the local source (if not already added):

```bash
dotnet nuget add source D:\Develop\DeskAssistant.Core\nuget -n LocalDeskAssistant
```

5. Verify the configured sources:

```bash
dotnet nuget list source
```

6. Add the package to the DeskAssistant project:

```bash
cd D:\Develop\DeskAssistant\DeskAssistant
dotnet add package DeskAssistant.Core --version 1.0.0
```

7. When making changes, rebuild the package and update the project:

```bash
dotnet pack -c Release -p:Version=1.0.1
dotnet add package DeskAssistant.Core --version 1.0.1
```

## 📁 Usage

This project is a library that can be referenced by the main DeskAssistant application.

---
