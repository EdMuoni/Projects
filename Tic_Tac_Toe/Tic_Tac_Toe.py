import pygame
import random

# Game settings
WIDTH, HEIGHT = 600, 600  # Width and height of the window
GRID_SIZE = 3  # Grid size (3x3 board)
CELL_SIZE = WIDTH // GRID_SIZE  # Size of each cell in the grid
LINE_WIDTH = 18  # Thickness of the lines separating cells
LINE_COLOR = (28, 170, 156)  # Color for the grid lines
BG_COLOR = (47, 38, 58)  # Background color
CIRCLE_COLOR = (242, 72, 100)  # Color for "O" (circle)
CROSS_COLOR = (28, 170, 156)  # Color for "X" (cross)

# Pygame initialization
pygame.init()
screen = pygame.display.set_mode((WIDTH, HEIGHT))  # Create a window with the defined width and height
pygame.display.set_caption("Tic-Tac-Toe")  # Set the window title
font = pygame.font.SysFont("comicsans", 40)  # Font settings for text (e.g., for winner announcement)

# Game board
board = [[" " for _ in range(GRID_SIZE)] for _ in range(GRID_SIZE)]  # Initialize a 3x3 empty board

# Check if a player has won the game
def check_win(board, symbol):
    # Horizontal and vertical checks
    for i in range(GRID_SIZE):
        if all([board[i][j] == symbol for j in range(GRID_SIZE)]) or \
           all([board[j][i] == symbol for j in range(GRID_SIZE)]):
            return True

    # Diagonal checks
    if all([board[i][i] == symbol for i in range(GRID_SIZE)]) or \
       all([board[i][GRID_SIZE - 1 - i] == symbol for i in range(GRID_SIZE)]):
        return True

    return False

# Check if the board is full (no empty spaces)
def is_board_full(board):
    return all(cell != " " for row in board for cell in row)

# Draw the grid lines
def draw_lines():
    for i in range(1, GRID_SIZE):
        # Horizontal lines
        pygame.draw.line(screen, LINE_COLOR, (0, i * CELL_SIZE), (WIDTH, i * CELL_SIZE), LINE_WIDTH)
        # Vertical lines
        pygame.draw.line(screen, LINE_COLOR, (i * CELL_SIZE, 0), (i * CELL_SIZE, HEIGHT), LINE_WIDTH)

# Draw the marks (X or O) on the board
def draw_marks():
    for row in range(GRID_SIZE):
        for col in range(GRID_SIZE):
            if board[row][col] == "X":
                # Draw "X" as two diagonal lines
                pygame.draw.line(screen, CROSS_COLOR, (col * CELL_SIZE, row * CELL_SIZE), ((col + 1) * CELL_SIZE, (row + 1) * CELL_SIZE), LINE_WIDTH)
                pygame.draw.line(screen, CROSS_COLOR, ((col + 1) * CELL_SIZE, row * CELL_SIZE), (col * CELL_SIZE, (row + 1) * CELL_SIZE), LINE_WIDTH)
            elif board[row][col] == "O":
                # Draw "O" as a circle
                pygame.draw.circle(screen, CIRCLE_COLOR, (col * CELL_SIZE + CELL_SIZE // 2, row * CELL_SIZE + CELL_SIZE // 2), CELL_SIZE // 3, LINE_WIDTH)

# Computer's move
def computer_move():
    # The computer randomly selects an empty cell on the board
    empty_cells = [(r, c) for r in range(GRID_SIZE) for c in range(GRID_SIZE) if board[r][c] == " "]
    if empty_cells:
        row, col = random.choice(empty_cells)
        board[row][col] = "O"

# Main game function
def play_game():
    current_player = "X"  # The game starts with player "X"
    game_over = False  # The game is not over initially
    while not game_over:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()  # Quit the game when the window is closed
                exit()

            if event.type == pygame.MOUSEBUTTONDOWN and not game_over:
                # Get the mouse position when clicked
                mouseX, mouseY = event.pos
                clicked_row = mouseY // CELL_SIZE  # Calculate which row was clicked
                clicked_col = mouseX // CELL_SIZE  # Calculate which column was clicked

                if board[clicked_row][clicked_col] == " ":
                    # If the clicked cell is empty, place the current player's mark there
                    board[clicked_row][clicked_col] = current_player

                    # Check if the current player has won the game
                    if check_win(board, current_player):
                        game_over = True
                    # Check if the board is full (draw)
                    elif is_board_full(board):
                        game_over = True

                    # Switch to the other player
                    current_player = "O" if current_player == "X" else "X"

        screen.fill(BG_COLOR)  # Fill the background with the defined color
        draw_lines()  # Draw the grid lines
        draw_marks()  # Draw the marks on the grid

        if game_over:
            winner = "X" if current_player == "O" else "O"  # The winner is the player who made the last move
            text = font.render(f"{winner} wins!" if winner != "O" else "It's a draw!", True, (255, 255, 255))  # Display the result
            screen.blit(text, (WIDTH // 4, HEIGHT // 4))  # Display the text in the center of the window

        # If it's the computer's turn and the game isn't over
        if current_player == "O" and not game_over:
            computer_move()  # Let the computer make its move
            if check_win(board, "O"):
                game_over = True
            elif is_board_full(board):
                game_over = True
            current_player = "X"  # Switch back to the player

        pygame.display.update()  # Update the display

# Run the game
if __name__ == "__main__":
    play_game()
