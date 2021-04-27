# Navmesh AI Tutorial 14 - Procedural NavMesh Generation at Runtime Part 2
The below video is the tutorial that **ENDS** where this project is. In the tutorial I review how to construct pieces of level so feel free to follow along with this project.

[![Youtube Tutorial](./Video%20Screenshot.png)](https://youtu.be/hC27myJAmM4&ref=github)


## Patreon Supporters
Have you been getting value out of these tutorials? Do you believe in LlamAcademy's mission of helping everyone make their game dev dream become a reality? Consider becoming a Patreon supporter and get your name added to this list, as well as other cool perks.
Head over to https://patreon.com/llamacademy to show your support.

### Gold Tier Supporters
* YOUR NAME HERE!

### Silver Tier Supporters
* YOUR NAME HERE!

### Bronze Tier Supporters
* Bastian
* YOUR NAME HERE!

In this project we have 3 Scenes:

SampleScene:
1. Simple click to move.
2. An enemy that follows the player
3. NavMeshLinks to allow the player and enemy to jump from one platform to another, and on top of some walls.
4. AgentLinkMover to control how NavMeshAgents will traverse NavMeshLinks
5. Animated 3D Model based on NavMeshAgent's movement
6. Dynamically spawned enemies at random points on the NavMesh
7. 4 Enemy types, configured via a ScriptableObject, that path differently based on Agent Configuration
8. Enemies and Player attack the other when they near each other, until dead.
9. Ranged Attacking Enemies
10. Configurable Homing Bullet Mechanics for Ranged Enemies
11. Improved ScriptableObject Configurations
12. Flying Enemies
13. State Machine AI with 3 options - idle, patrol, chase, including line of sight checking

Progressive NavMesh
1. A Player-only scene with a procedurally generated world and NavMesh so it can be navigated by a NavMeshAgent

Bake NavMesh in Bounds
1. A Player-only scene baking a NavMesh around the player as they move.

## Requirements
* Requires Unity 2019.4 LTS or higher. 
* Utilizes the [Navmesh Components](https://github.com/Unity-Technologies/NavMeshComponents) from Unity's Github.
