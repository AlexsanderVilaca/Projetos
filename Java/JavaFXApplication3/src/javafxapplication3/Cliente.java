/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javafxapplication3;

/**
 *
 * @author alexsander.rodrigues
 */
public class Cliente {
    
    private String nome;
    private String endereco;
    private String telefone;
    
    public String getNome(){
        return nome;
    }
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public String getEndereco(){
        return endereco;
    }
    public void setEndereco(String endereco){
        this.endereco = endereco;
    }
    
    public String getTelefone(){
        return telefone;
    }
    public void setTefefone(String telefone){
        this.telefone = telefone;
    }
    
    public Cliente(String nome, String endereco, String telefone){
        this.nome = nome;
        this.endereco = endereco;
        this.telefone = telefone;
    }
    
    public Cliente(){};

}
