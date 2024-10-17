
import React from 'react';
import Layout from '@theme/Layout';

/**
 * Renders the main component for the VTEX SDK Documentation.
 *
 * This function returns a layout component that includes a title and description
 * for the documentation, along with a welcome message and introductory text.
 *
 * @returns {JSX.Element} A JSX element representing the layout of the documentation page.
 *
 * @example
 * // Usage within a React component
 * const App = () => {
 *   return (
 *     <div>
 *       <Home />
 *     </div>
 *   );
 * };
 */
function Home() {
  return (
    <Layout
      title="VTEX SDK Documentation"
      description="Comprehensive documentation for VTEX SDK">
      <main>
        <h1>Welcome to VTEX SDK Documentation</h1>
        <p>Explore the documentation to understand how to use the VTEX SDK effectively.</p>
      </main>
    </Layout>
  );
}

export default Home;
