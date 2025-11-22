import pygame

# Pygame'i kood siia
pygame.init()

screen_width = 800
screen_height = 600
screen = pygame.display.set_mode((screen_width, screen_height))
pygame.display.set_caption("Pygame'i window")

running = True
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    screen.fill((255, 255, 255)) # Täida valge värviga
    pygame.display.flip() # Uuenda ekraani

pygame.quit()