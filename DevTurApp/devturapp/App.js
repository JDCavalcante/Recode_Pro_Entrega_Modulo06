import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View, ImageBackground } from 'react-native';
import Comp01 from './Components/comp01';
import Comp02 from './Components/comp02';


export default function App() {
  return (
    <View style={styles.container}>
      <ImageBackground source={require("./Components/Imagens/promo01.png")}  resizeMode="stretch" no-repeat style={styles.image}>
      <Comp01/>
      <StatusBar style="auto" />
      </ImageBackground>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
  },
  image: {
    flex: 1,
    justifyContent: "center"
  }
});
