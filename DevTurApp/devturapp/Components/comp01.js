import React, { useState } from 'react';
import { Alert, View, ScrollView, Text, Image, Button, StyleSheet, } from 'react-native';

const dadosIniciais = [
    { id: 1},
    { id: 2},
    { id: 3},
    { id: 4}
  
  ];
  


export default function App() {
    const [ dados, setDados ] = useState(null);
  
    const getData = (idDados) => {
      const endpoint = `https://localhost:7062/api/clientes`;
  
      fetch(endpoint)
        .then(resposta => resposta.json())
          .then( json => {
            const lista = {
              nome: json.name,
              id: json.id,
              email: json.email,
            };
  
            setdados(lista);
          })
          .catch(() => {
            Alert.alert('Erro', 'Não foi possível carregar os dados do cliente');
          });
    }

    return (
        <View style={styles.container}>
          <ScrollView>
            <View style={styles.topo}>
              <Text style={styles.topoTitulo}>Listar</Text>
            </View>
    
            {dados != null && (
              <View style={styles.pokemonBox}>
                <Text style={styles.pokemonNome}>Nome: {dados.nome}</Text>
                <Text style={styles.pokemonPeso}>Peso: {dados.id}</Text>
                <Text style={styles.pokemonPeso}>Peso: {dados.email}</Text>
                
              </View>
            )}
    
            {dadosIniciais.map( lista => (
              <View style={styles.cardContainer}>
                <Text style={styles.cardTitle}>{lista.nome}</Text>
                <Button title="Dados" onPress={()=>getData(lista.id)}/>
              </View>
            ))}
          </ScrollView>
        </View>
      );
    }

    
const styles = StyleSheet.create({
    container: { flex: 1, backgroundColor: '#fff' },
  
    topo: { height: 80, padding: 20, paddingTop: 40, marginBottom: 20, backgroundColor: '#e73e33' },
    topoTitulo: { fontSize: 22, marginBottom: 10, color: '#fff', textAlign: 'center'},
  
    cardContainer: { borderWidth: 1, borderColor: '#d5d5d5', borderRadius: 4, marginBottom: 10, marginHorizontal: 20, padding: 10 },
    cardTitle: { fontSize: 22, marginBottom: 20, textAlign: 'center', color: '#656565' },
  
    pokemonBox: { alignItems: 'center' },
    pokemonNome: { fontSize: 22 },
    pokemonPeso: { fontSize: 18 },
    pokemonImg:{ width: 150, height: 150,}
  });