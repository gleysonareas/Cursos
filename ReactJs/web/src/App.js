import './App.css';
import PromotionCard from 'components/promotion/card/card';

function App() {

    const promotion = {
        " id ": 1,
        " title ": " Kit Notebook Acer Aspire 3 + Mochila Green, A315-41-R790, AMD Ryzen 3 2200U Dual Core ",
        " preço ": 1799,
        " imageUrl ": " https://cdn.gatry.com/gatry-static/promocao/imagem_url/2631517face1861bc4f46ae154d387de.png ",
        " url ": " https://www.amazon.com.br/Notebook-Acer-Mochila-A315-41-R790-Mem%C3%B3ria/dp/B07YDWLV7S/ref=as_li_ss_tl?ie=UTF8&linkCode=sl1&tag=gatry0b -20 & linkId = e4a1146599e36741a720a6a952cbc328 & language = pt_BR ",
        " comentários ": [{
            " id ": 1,
            " comentário ": " TELA HD "
        }]
    }

    return ( <
        div className = "App" >
        <
        PromotionCard promotion = { promotion }
        /> <
        /div>
    );
}

export default App;