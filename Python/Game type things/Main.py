import pygame


pygame.init()

#Display Settings
display_width = 800
display_height =600

gameDisplay = pygame.display.set_mode((display_width,display_height))
pygame.display.set_caption('Catpocolipse/What a Catastrophee! [WIP]')
clock = pygame.time.Clock()

#Variables and values
black = (0,0,0)
white = (255,255,255)
red = (255,0,0)
green = (0,255,0)
blue = (0,0,255)

playerX = 0
playerY = 128
playerL = 1

gameQuit = False

#Image Loading

#Define Class
def player(playerX,playerY,playerL):
  gameDisplay.blit(pygame.draw.rect(gameDisplay, blue, [x,y]))

#Event Handling
while not gameQuit:
  for event in pygame.event.get():
    if event.type == pygame.QUIT:
      pygame.quit()
      quit()

    


#Happening on screen

gameDisplay.fill(white)
player(playerX,playerY)

pygame.display.update()
clock.tick(60)



