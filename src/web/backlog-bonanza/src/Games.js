import React, { useEffect, useState } from "react";
import Game from './Game'

const Games = () => {
  const [games, setGames] = useState([]);

  useEffect(() => {
    fetch("")
      .then((data) => data.json())
      .then(setGames())
      .catch((err) => console.error(err));
    return games;
  }, []);

  return (
    <>
      <h1>Hello</h1>
      {games && games.map((game, i) => (
        <Game 
        key={i} 
        title={game.title} isFinished={game.isFinished}
            platform={game.platform}
        />)
    )}
      
    </>
  );
};

export default Games;
