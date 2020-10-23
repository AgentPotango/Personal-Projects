import { ServerRespond } from './DataStreamer';

//changed structure of Row interface to match structure produced by generateRow() and hence the schema.
export interface Row {
    price_abc: number,
    price_def: number,
    ratio: number,
    timestamp: Date,
    upper_bound: number,
    lower_bound: number,
    trigger_alert: number | undefined,
}


export class DataManipulator {
  //returns singular row object instead of array of row objects
  static generateRow(serverRespond: ServerRespond[]): Row {
      // finds the average of the top_ask price and top_bid brice for each stock as the value for the price
      const priceABC = (serverRespond[0].top_ask.price + serverRespond[0].top_bid.price)/2;
      const priceDEF = (serverRespond[1].top_ask.price + serverRespond[1].top_bid.price)/2;
      // calculates the ratio of the prices
      const ratio = priceABC / priceDEF;
      // Set up bounds for the trigger. Ratio supposed to trigger if any bound is exceeded.
      const upperBound = 1 + 0.05;
      const lowerBound = 1 - 0.05;
      // timestamp returns whichever timestamp is larger
      // if ratio is > upperbound, trigger alert is set to ratio. Similar for ratio < lowerBound.
      // ratio remains the same then trigger alert is undefined and will not show
      return {
        price_abc: priceABC,
        price_def: priceDEF,
        ratio,
        timestamp: serverRespond[0].timestamp > serverRespond[1].timestamp ?
            serverRespond[0].timestamp : serverRespond[1].timestamp,
        upper_bound: upperBound,
        lower_bound: lowerBound,
        trigger_alert: (ratio > upperBound || ratio < lowerBound) ? ratio : undefined,
      };
  }
}
