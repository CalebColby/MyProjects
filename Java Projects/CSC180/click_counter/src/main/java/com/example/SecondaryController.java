package com.example;

import java.io.IOException;
import javafx.fxml.FXML;
import javafx.scene.control.Button;

public class SecondaryController {

    private int clicks = 0;

    @FXML
    private Button counterButton;

    @FXML
    private void switchToPrimary() throws IOException {
        App.setRoot("primary");
    }

    @FXML
    private void countClick() {
        clicks++;

        System.out.println("The Button was Clicked");
        System.out.println(clicks);

        counterButton.setText("Counted Clicks: " + clicks);
    }
}