# Cow and Farmer (3D Simulation Game)

A dynamic 3D simulation and resource/management game built using **Unity 6 (6000.0.41f1)**. The game explores interactive state loops between a playable or automated Farmer and autonomous Cow entities, managing tasks like herding, feeding, resource collection, or path-navigation inside a stylized 3D environment.

---

## 🚀 Key Features

* **Unity 6 Native Pipeline:** Developed using the latest features and performance optimizations of Unity 6000.0.41f1.
* **3D Entity State Management:** Autonomous behaviors for livestock (Cows) balanced with interactive loops triggered by the Farmer.
* **Algorithmic Pathfinding & Navigation:** Smooth coordinate movement grid mapping to handle tracking, avoidance, and designated pen boundaries.
* **Clean Production Setup:** Fully pre-configured with active asset tracking via Git LFS for stable large-binary tracking and `.meta` asset persistence.

---

## 📂 Project Architecture & Script Breakdown

The core logic splits responsibilities between human interaction handlers and animal behavior arrays inside the `Assets/` directory:

### 🧑‍🌾 Farmer & Environment Systems
* **`FarmerController.cs`**: Processes player inputs or management tasks, steering the farmer model across the terrain to interact with assets or herd livestock.
* **`GameManager.cs` / Simulation Core**: Orchestrates global parameters such as total animal count, collected resources, score thresholds, or active state loops.

### 🐄 Cow AI & Interaction Logic
* **`CowAI.cs` / Behavior States:** Manages individual animal cycles—including random wandering (grazing), running away from threats, feeding trackers, or returning to shelter.
* **`InteractionTrigger.cs`**: Listens for 3D physics collisions or proximity bubbles between the farmer and cows to trigger herding or feedback effects.

---

## 🎮 Controls

* **Move Farmer:** Use `W`, `A`, `S`, `D` or the **Arrow Keys** to navigate the farmer through the 3D map.
* **Interact / Action:** Press the **Spacebar**  to perform context-driven actions (e.g., feeding, gathering, herding).

---

## 🛠️ Getting Started

### Prerequisites
* **Unity Hub & Editor:** Version **6000.0.41f1** or a compatible modern Unity 6 release.
* **Git Extensions:** Git Large File Storage (**Git LFS**) configured globally.

### Installation & Setup

1. **Initialize Git LFS** on your system before cloning binary asset configurations:
   ```bash
   git lfs install
