package com.example;

import java.io.IOException;
import java.util.Random;

import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;

public class SecondaryController {
    //private ImageView holeImage = new ImageView(new Image("C:\\Users\\Ccolby\\OneDrive - Neumont College of Computer Science\\Documents"
    //+ "\\My Projects\\Github\\Java Projects\\CSC180\\whack_a_mole\\src\\main\\resources\\com\\example\\img\\hole.jpg"));
    //private ImageView moleImage = new ImageView(new Image("src\\main\\resources\\com\\example\\img\\Mole.jpg"));;
    //private ImageView whackImage = new ImageView(new Image("src\\main\\resources\\com\\example\\img\\whack.jpg"));

    @FXML
    private Button MoleButton1;
    @FXML
    private Button MoleButton2;
    @FXML
    private Button MoleButton3;
    @FXML
    private Button MoleButton4;
    @FXML
    private Button MoleButton5;
    @FXML
    private Button MoleButton6;
    @FXML
    private Button MoleButton7;
    @FXML
    private Button MoleButton8;
    @FXML
    private Button MoleButton9;

    @FXML
    private Button StartButton;
    @FXML
    private Label timerLabel;
    @FXML
    private Label resultsLabel;


    private boolean gameRunning = false;
    private int winningScore = 10;
    private int points = 0;
    private String holeText = "Empty";
    private String moleText = "Mole";


    @FXML
    private void switchToPrimary() throws IOException {
        App.setRoot("primary");
    }

    @FXML
    private void startGame() {
        points = 0;

        SetupButtons();

        do{
            SelectTextForAllButtons();
        } while(!CheckIfPlayable());

        StartButton.setText("Restart Game");
        gameRunning = true;
    }

    private void SetupButtons() {
        MoleButton1.setOnAction(e -> {whack(MoleButton1);});
        MoleButton2.setOnAction(e -> {whack(MoleButton2);});
        MoleButton3.setOnAction(e -> {whack(MoleButton3);});
        MoleButton4.setOnAction(e -> {whack(MoleButton4);});
        MoleButton5.setOnAction(e -> {whack(MoleButton5);});
        MoleButton6.setOnAction(e -> {whack(MoleButton6);});
        MoleButton7.setOnAction(e -> {whack(MoleButton7);});
        MoleButton8.setOnAction(e -> {whack(MoleButton8);});
        MoleButton9.setOnAction(e -> {whack(MoleButton9);});
    }

    @FXML
    private void whack(Button clickedButton) {
        if(!gameRunning || clickedButton == null) return;
        if(clickedButton.getText() != moleText) return;

        Random randy = new Random();

        resultsLabel.setText("Go to qwertyuiopasdfghjklzxcvbnm.com and see if it exists");
        if(randy.nextInt(7) % 2 == 0){
            points++;
            resultsLabel.setText("You Whacked the " + moleText + "!!");
        }else{
            resultsLabel.setText("The " + moleText + " escaped your Whack!!");
        }

        if(points == winningScore) gameOver(true);

        SelectTextForAllButtons();

        if(!CheckIfPlayable()) gameOver(false);
    }

    private void SelectTextForAllButtons() {
        MoleButton1.setText(SelectText());
        MoleButton2.setText(SelectText());
        MoleButton3.setText(SelectText());
        MoleButton4.setText(SelectText());
        MoleButton5.setText(SelectText());
        MoleButton6.setText(SelectText());
        MoleButton7.setText(SelectText());
        MoleButton8.setText(SelectText());
        MoleButton9.setText(SelectText());
    }

    private String SelectText() {
        switch(new Random().nextInt(2)){
            case 0:
                return holeText;
            case 1:
                return moleText;
            default:
                throw new IllegalArgumentException();
        }
    }

    private boolean CheckIfPlayable(){
        if(MoleButton1.getText() == moleText) return true;
        if(MoleButton2.getText() == moleText) return true;
        if(MoleButton3.getText() == moleText) return true;
        if(MoleButton4.getText() == moleText) return true;
        if(MoleButton5.getText() == moleText) return true;
        if(MoleButton6.getText() == moleText) return true;
        if(MoleButton7.getText() == moleText) return true;
        if(MoleButton8.getText() == moleText) return true;
        if(MoleButton9.getText() == moleText) return true;
        return false;
    }

    private void gameOver(boolean playerWon){
        gameRunning = false;

        if(playerWon){
            resultsLabel.setText("You Won!!!\nYour Score: " + points);
        }else{
            resultsLabel.setText("Game Over\nYour Score: " + points);
        }
        
        StartButton.setText("Start New Game");
    }
}