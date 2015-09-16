# Pacman

The Pac-Man game is a popular arcade game. The user plays as Pac-Man, who eats “pac-dots” that are scattered around a maze. There are four enemy ghosts wandering around the maze, who try to stop Pac-Man.

# Unity Objects

- One Camera
- Three empty object (PacMan, Ghost, Maze)
- Sprites (Pacman, open and closed, ghost, cookies, background)

# Unity Components

- Add the Ghost_AI.cs to the ghost object. Add the Collision.cs to the ghost's collider objects and set as Is Trigger.
- Add the Maze.cs to the maze object.
- Add the PacmanControl.cs to the pacman object.
- Add the Cookie.cs to the cookie object and set as Is Trigger.
- Add the MainMenu.cs to the Main Camera in the MainMenu and GameOver scenes.
- The Camera should be at about (4, 3.6, -10)
