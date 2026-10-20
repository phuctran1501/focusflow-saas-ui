# <img src="wwwroot/images/logo.svg" width="36" height="36" valign="middle" alt="FocusFlow Logo" /> FocusFlow SaaS UI

> A modern productivity and focus-tracking SaaS dashboard built with HTML5, CSS3, and ASP.NET Core MVC. UI-focused project featuring responsive layouts, analytics cards, deep work focus sessions, and task management with rich mock data.

<p align="left">
  <a href="https://dotnet.microsoft.com/"><img src="https://img.shields.io/badge/ASP.NET%20Core-10.0-512BD4?logo=dotnet&logoColor=white" alt="ASP.NET Core" /></a>
  <a href="https://docs.microsoft.com/dotnet/csharp/"><img src="https://img.shields.io/badge/C%23-13.0-239120?logo=csharp&logoColor=white" alt="C#" /></a>
  <a href="https://sass-lang.com/"><img src="https://img.shields.io/badge/SCSS-Sass%201.90-CC6699?logo=sass&logoColor=white" alt="SCSS" /></a>
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License" /></a>
</p>

---

## 🌟 Project Overview

**FocusFlow** is designed to solve digital distraction and fragmented daily planning by merging high-leverage focus sessions, goal tracking, and productivity analytics into one cohesive, distraction-free SaaS experience.

Built **UI-First** to master modern web layout architecture, responsive Flexbox/Grid design, CSS tokens, and component reusability within **ASP.NET Core MVC** without heavy runtime dependencies like React, Tailwind, or complex databases.

---

## 📸 Screenshots & Previews

### 01. Dashboard (`/`)

_Greeting, 4 KPI cards, interactive CSS weekly focus bar chart, live time tracker widget, and today's priority plan._
![FocusFlow Dashboard](wwwroot/images/dashboard.png)

---

### 02. Focus Room (`/Focus`)

_Cosmic dark-mode distraction-free flow state, circular countdown timer with animated SVG ring progress, session tasks, day structure presets, and ambient soundscapes synthesized via Web Audio API._
![Focus Room](wwwroot/images/focus-room.png)

---

### 03. My Tasks (`/Tasks`)

_Comprehensive SaaS table layout featuring status metric chips, priority badges, category filters, interactive completion checkboxes, and dynamic task creation modal._
![My Tasks](wwwroot/images/tasks.png)

---

### 04. Insights (`/Insights`)

_Productivity analytics dashboard featuring a weekly score indicator, smooth spline wave SVG chart, 12-day streak card with community percentiles, radial donut completion ring, and AI productivity highlights._
![Productivity Insights](wwwroot/images/insights.png)

---

## 🚀 Key Features

| Screen         | Route       | Key UI Components                                                                                                                                                                                                                                    |
| -------------- | ----------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Dashboard**  | `/`         | Greeting banner, 4 KPI metric cards (Projects, Tasks, Hours, Dot streak matrix), weekly focus bar chart with peak indicator & tooltips, quick time tracker widget, today's plan.                                                                     |
| **Focus Room** | `/Focus`    | Mode tabs (`Focus 25m`, `Short Break 5m`, `Long Break 15m`), circular SVG radial timer, start/pause/reset/skip controls, checkable goal queue, Day Structures (_Deep Work_, _Study Mode_, _Power Day_), and native Web Audio rain ambient generator. |
| **My Tasks**   | `/Tasks`    | Top search bar, filter tabs (`All`, `To do`, `Doing`, `Overdue`, `Completed`), priority filter, 6 metric summary chips, clean SaaS table with avatars and subtask counters, and interactive "+ Create Task" modal.                                   |
| **Insights**   | `/Insights` | Weekly productivity score (84.2%), smooth SVG wave spline chart with gradient fill, 12-day streak card with avatar stack, donut chart with 85% completion, and 3 highlight cards (_Peak Focus_, _Consistency King_, _Rest Insight_).                 |

---

## 🎨 Design System & Color Palette

The UI utilizes a tailored SaaS design token system defined in CSS variables (`wwwroot/css/site.css`):

- **Primary**: `#635BFF` (Stripe-inspired vivid indigo)
- **Background**: `#F6F7FB` (Light neutral slate)
- **Text Main**: `#202438` (Deep navy charcoal)
- **Card Surface**: `#FFFFFF` (Card radius: `16px`, soft elevation shadows)
- **Success**: `#0E7A4A` (Background: `#D9FBE7`)
- **Warning**: `#B35C00` (Background: `#FFE9CB`)
- **Danger**: `#D9383A` (Background: `#FEE7E7`)
- **Typography**: `Inter` and `Plus Jakarta Sans` via Google Fonts.

---

## 🛠️ Technology Stack

- **HTML5 & Razor Views**: Semantic markup and layout templating (`_Layout.cshtml`, `_Sidebar.cshtml`).
- **CSS3 (Pure Vanilla)**: Custom Flexbox, CSS Grid, CSS Variables, SVG curves, keyframe animations, and custom scrollbars (no Tailwind dependency).
- **C# / ASP.NET Core MVC**: Clean Controller-ViewModel architecture rendering mock data models.
- **JavaScript (Vanilla)**: Non-intrusive interactive widgets:
  - Circular timer countdown with SVG stroke-dashoffset animation.
  - Native Web Audio API pink/brown noise rain synthesizer for focus soundscapes.
  - Client-side table filtering, search, and dynamic task modal creation.
  - Keyboard shortcuts (`⌘ F` / `Ctrl+K`) and mobile drawer offcanvas menu.

---

## 📁 Repository Structure

```
focusflow-saas-ui/
├── Controllers/
│   ├── HomeController.cs        # Renders Dashboard with weekly trends & tasks
│   ├── FocusController.cs       # Renders Focus Room with day structures & presets
│   ├── TasksController.cs       # Renders Tasks table with metric summary chips
│   └── InsightsController.cs    # Renders Analytics, wave chart & completion donut
├── Models/
│   ├── FocusSession.cs          # Focus session data model
│   └── TaskItem.cs              # Task item data model (priority, status, assignee)
├── ViewModels/
│   ├── DashboardViewModel.cs    # View model for Home dashboard
│   ├── FocusViewModel.cs        # View model for Focus Room
│   ├── TasksViewModel.cs        # View model for Tasks table
│   └── InsightsViewModel.cs    # View model for Insights analytics
├── Views/
│   ├── Home/Index.cshtml        # Dashboard view
│   ├── Focus/Index.cshtml       # Focus room view with circular timer
│   ├── Tasks/Index.cshtml       # Task table view with create modal
│   ├── Insights/Index.cshtml    # Insights view with SVG wave chart
│   └── Shared/
│       ├── _Layout.cshtml       # Global SaaS app shell & header
│       └── _Sidebar.cshtml      # Reusable sidebar navigation
├── wwwroot/
│   ├── css/
│   │   ├── site.css             # CSS variables, color tokens, typography
│   │   ├── layout.css           # App shell, sidebar, top header, responsive breakpoints
│   │   ├── components.css       # Cards, badges, buttons, checkboxes, modal, tabs
│   │   └── pages/
│   │       ├── dashboard.css    # Dashboard KPI & bar chart styles
│   │       ├── focus.css        # Cosmic dark theme focus room styles
│   │       ├── tasks.css        # SaaS data table & metric chips styles
│   │       └── insights.css     # Wave chart, donut ring & insight cards
│   ├── js/
│   │   └── site.js              # Mobile navigation drawer & shortcuts
│   └── images/                  # High-resolution screenshots of completed pages
├── Program.cs                   # Application entry point
├── FocusFlow.csproj             # .NET 10 project file
└── README.md
```

---

## 💻 Getting Started Locally

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download) (or .NET 8 / 9 SDK compatible)

### Steps to Run

1. Clone the repository:

   ```bash
   git clone https://github.com/<YOUR_USERNAME>/focusflow-saas-ui.git
   cd focusflow-saas-ui
   ```

2. Restore dependencies and build:

   ```bash
   dotnet build
   ```

3. Run the development server:

   ```bash
   dotnet run --launch-profile http
   ```

4. Open your browser and navigate to:
   ```
   http://localhost:5005
   ```

---

## 🎯 Learning Outcomes

- **Design Systems & CSS Architecture**: Structured maintainable CSS using variables, utilities, and page-specific isolation.
- **Advanced Responsive Layouts**: Fluid responsive transitions across desktop, tablet, and mobile offcanvas drawers using CSS Grid and Flexbox.
- **Component Reusability**: Created reusable Razor layouts, sidebars, badges, tabs, and modal components.
- **Lightweight SVG Data Visualization**: Implemented custom bar charts, spline wave curves, and donut charts without third-party chart libraries.
- **Web Audio API**: Implemented ambient audio generation directly in the browser.

---

## 📄 License

This project is open-source under the [MIT License](LICENSE).
