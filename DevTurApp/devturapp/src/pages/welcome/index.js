import {View,
        Text, 
        StyleSheet,
        Image,
        TouchableOpacity
    } from 'react-native'
import React from 'react'
import { useNavigation } from '@react-navigation/native'
import * as Animatable from 'react-native-animatable'

const Welcome = () => {
    const navigation = useNavigation();
  return (
    <View style={styles.container}>
      
      <View style={styles.containerLogo}>
        <Animatable.Image
        animation="flipInY"
        source = {require('../../Imagens/promo01.jpg')} 
        style={{width:'100%'}}
        resizeMode="contain" 
        /> 
      </View>

      <Animatable.View delay={600} animation="fadeInUp"  style={styles.containerForm}>
        <Text style={styles.title}> Devtur App </Text>
        <Text style={styles.text}> Faça o Login</Text>

        <TouchableOpacity 
        style={styles.button}
        onPress={() => navigation.navigate('SignIn')}
        >
            <Text style={styles.buttonText}>Acessar</Text>
        </TouchableOpacity>
      </Animatable.View>
    </View>
  )
}

const styles = StyleSheet.create({
    container:{
        flex:1,
        backgroundColor: "gray"
    },
    containerLogo:{
        flex:2,
        backgroundColor: "gray",
        justifyContent: 'center',
        alignItems: 'center'
    },
    containerForm:{
        flex:1,
        backgroundColor: "snow",
        borderTopLeftRadius:25,
        borderTopRightRadius:25,
        paddingStart:'5%',
        paddingEnd:'5%'
    },
    title:{
        fontSize: 24,
        fontWeight: 'bold',
        marginTop:28,
        marginBottom:12
    },
    text:{
        color:"#a1a1a1"
    },
    button:{
        position:'absolute',
        backgroundColor:'green',
        borderRadius:50,
        paddingVertical:8,
        width: '60%',
        alignSelf:'center',
        bottom:'15%',
        alignItems:'center',
        justifyContent:'center'
    },
    buttonText:{
        fontSize: 18,
        color: '#FFF',
        fontWeight:'bold'

    }
})

export default Welcome