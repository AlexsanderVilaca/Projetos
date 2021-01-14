/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javafxapplication3;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.Alert.AlertType;
import javafx.scene.control.Button;
import javafx.scene.control.ButtonType;
import javafx.scene.control.TextField;
import static javafxapplication3.FXMLDocumentController.ImprimeMessageBox;

/**
 *
 * @author alexsander.rodrigues
 */
public class FXMLDocumentController implements Initializable {

    @FXML
    private TextField txtNome;
    @FXML
    private TextField txtEndereco;
    @FXML
    private TextField txtTelefone;
    @FXML
    private Button btnCadastrar;

    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }

    @FXML
    private void handleEvent(ActionEvent event) {
        String nome = txtNome.getText();
        String endereco = txtEndereco.getText();
        String telefone = txtTelefone.getText();
        
        if(nome.length() < 4 || endereco.length() < 10 || telefone.length() < 9){
            ImprimeMessageBox("Atenção","Preencha tods os os campos", true);
        }
        
    }
    
    public static void ImprimeMessageBox(String titulo, String mensagem, boolean finalizarPrograma){
        Alert a = new Alert(AlertType.INFORMATION);
        a.setTitle(titulo);
        a.setContentText(mensagem);
        a.showAndWait().ifPresent(rs -> {
            if(rs == ButtonType.OK)
                a.close();
        });
        
        if(finalizarPrograma)
            return;
        /*
        Alert alert = new Alert(AlertType.INFORMATION);
        alert.setContentText("voce fez $%$$%");
        alert.showAndWait().ifPresent(rs -> {
            if (rs == ButtonType.OK) {
                System.out.println("Ok, voce desfez a $¨¨$@#");
            }
        });

        uma outra forma de fazer uma messagebox MessageBox mb = new MessageBox("OK or cancel?", MessageBoxType.OK_CANCEL);
        
        mb.showAndWait();
        if (mb.getMessageBoxResult() == MessageBoxResult.OK) {
            System.out.println("OK");
        } else {
            System.out.println("Cancel");
        }
        */
    }
    

}
